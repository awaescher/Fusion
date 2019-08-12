using FusionPlusPlus.Engine.IO;
using FusionPlusPlus.Engine.Model;
using System;
using System.IO;

namespace FusionPlusPlus.Engine.IO
{
	public class LogFileService : ILogFileService
	{
		public LogFileService(ILogStore store)
		{
			Store = store ?? throw new ArgumentNullException(nameof(store));
		}

		public string[] Get(LogSource source, string filter = "")
		{
			var path = Path.Combine(Store.Path, source == LogSource.NativeImage ? "NativeImage" : "Default");

			if (!Directory.Exists(path))
				return new string[0];

			return Directory.GetFiles(path, "*.htm", SearchOption.AllDirectories);
		}

		public ILogStore Store { get; }
	}
}
