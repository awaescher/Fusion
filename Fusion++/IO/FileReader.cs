using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionPlusPlus.IO
{
	internal class FileReader : IFileReader
	{
		public string Read(string filePath)
		{
			return File.ReadAllText(filePath, Encoding.UTF8);
		}
	}
}
