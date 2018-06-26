using FusionPlusPlus.Model;
using System;
using System.IO;

namespace FusionPlusPlus.Services
{
	internal class LogFileService : ILogFileService
	{
		public LogFileService(IFusionService fusionService)
		{
			FusionService = fusionService ?? throw new ArgumentNullException(nameof(fusionService));
		}

		public string[] Get(LogSource source, string filter = "")
		{
			var path = Path.Combine(FusionService.LogPath, source == LogSource.NativeImage ? "NativeImage" : "Default");
			return Directory.GetFiles(path, "*.htm", SearchOption.AllDirectories);
		}

		public IFusionService FusionService { get; }
	}
}
