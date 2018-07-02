using FusionPlusPlus.Model;
using Microsoft.Win32;
using System;
using System.IO;

namespace FusionPlusPlus.Services
{
	internal class DiskReadOnlyFusionService : IFusionService
	{
		public DiskReadOnlyFusionService(string path)
		{
			Path = path;
		}

		public LogMode Mode
		{
			get => LogMode.All;
			set => throw new NotSupportedException();
		}

		public string LogPath
		{
			get => Path;
			set => throw new NotSupportedException();
		}

		public bool Immersive
		{
			get => false;
			set => throw new NotSupportedException();
		}

		public string Path { get; }
		
	}
}