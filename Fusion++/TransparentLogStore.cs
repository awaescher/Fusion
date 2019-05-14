using FusionPlusPlus.Model;
using FusionPlusPlus.Parser;
using System;
using FusionPlusPlus.Services;

namespace FusionPlusPlus
{
	internal class TransparentLogStore : ILogStore
	{
		public TransparentLogStore(string path)
		{
			Path = path;
		}

		public void Prepare()
		{
			Prepared = true;
		}

		public string GetLogName(string path) => path;

		public string Path { get; set; }

		public bool Prepared { get; private set; }
	}
}
