using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionPlusPlus
{
	internal class TemporaryLogStore : ILogStore
	{
		public TemporaryLogStore()
		{
			TopLevelPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Fusion++");
			Path = System.IO.Path.Combine(TopLevelPath, DateTime.UtcNow.ToString("yyyy.MM.dd.HH.mm.ss.ffff"));
		}

		public string TopLevelPath { get; }

		public string Path { get; }

		public void Prepare()
		{
			if (!Directory.Exists(Path))
				Directory.CreateDirectory(Path);
		}
	}
}
