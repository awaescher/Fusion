using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FusionPlusPlus.Engine.IO
{
	public class TransparentLogStore : ILogStore
	{
		protected const string UTC_DATE_FORMAT = "yyyy.MM.dd.HH.mm.ss.ffff";

		public TransparentLogStore(string path)
		{
			Path = path;
		}

		public virtual void Prepare()
		{
			Prepared = true;
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

		public string Path { get; set; }

		public bool Prepared { get; private set; }
	}
}
