using FusionPlusPlus.Engine.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionPlusPlus.Tests
{
	internal class PathAsContentRoutingFileReader : IFileReader
	{
		public string Read(string filePath) => filePath;
	}
}
