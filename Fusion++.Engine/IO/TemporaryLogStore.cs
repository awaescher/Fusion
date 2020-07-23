using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;

namespace FusionPlusPlus.Engine.IO
{
	public class TemporaryLogStore : ILogStore
	{
		private const string UTC_DATE_FORMAT = "yyyy.MM.dd.HH.mm.ss.ffff";

		public TemporaryLogStore()
		{
			TopLevelPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Fusion++");
			Path = System.IO.Path.Combine(TopLevelPath, DateTime.UtcNow.ToString(UTC_DATE_FORMAT));
		}

		public string TopLevelPath { get; }

		public string Path { get; }

		public void Prepare()
		{
			if (!Directory.Exists(Path))
			{
				Directory.CreateDirectory(Path);

				try
				{
					SetFullControlPermissions(Path, WellKnownSidType.BuiltinUsersSid, WellKnownSidType.LocalSystemSid, WellKnownSidType.WorldSid);
				}
				catch
				{
					// setting full control permissions is what we want to have for IIS logging, however we can 
					// live without it: https://github.com/awaescher/Fusion/issues/14
				}
			}
		}

		static void SetFullControlPermissions(string path, params WellKnownSidType[] sids)
		{
			const FileSystemRights rights = FileSystemRights.FullControl;

			foreach (var sid in sids)
			{
				bool result;
				bool inheritedResult;

				var securityIdentifier = new SecurityIdentifier(sid, null);

				// Add Access Rule to the actual directory itself
				var accessRule = new FileSystemAccessRule(
					securityIdentifier,
					rights,
					InheritanceFlags.None,
					PropagationFlags.NoPropagateInherit,
					AccessControlType.Allow);

				var info = new DirectoryInfo(path);
				var security = info.GetAccessControl(AccessControlSections.Access);

				security.ModifyAccessRule(AccessControlModification.Set, accessRule, out result);

				if (!result)
					throw new InvalidOperationException("Failed to give full-control permission to all users for path " + path);

				// add inheritance
				var inheritedAccessRule = new FileSystemAccessRule(
					securityIdentifier,
					rights,
					InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
					PropagationFlags.InheritOnly,
					AccessControlType.Allow);

				security.ModifyAccessRule(AccessControlModification.Add, inheritedAccessRule, out inheritedResult);

				if (!inheritedResult)
					throw new InvalidOperationException("Failed to give full-control permission inheritance to all users for " + path);

				info.SetAccessControl(security);
			}
		}

		public string GetLogName(string path)
		{
			var result = System.IO.Path.GetFileName(path);
			if (DateTime.TryParseExact(result, UTC_DATE_FORMAT, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeUniversal, out DateTime date))
				result = date.ToShortDateString() + " " + date.ToLongTimeString();

			var apps = new List<string>();
			foreach (var subfolder in new string[] { "Default", "NativeImage" })
			{
				var folder = System.IO.Path.Combine(path, subfolder);
				if (Directory.Exists(folder))
					apps.AddRange(Directory.GetDirectories(folder).Select(System.IO.Path.GetFileName));
			}

			if (apps.Any())
			{
				apps = apps.Distinct().OrderBy(name => name).ToList();

				if (apps.Count > 5)
					apps = apps.Take(5).Union(new string[] { "..." }).ToList();

				result += " " + string.Join(", ", apps);
			}

			return result;
		}
	}
}
