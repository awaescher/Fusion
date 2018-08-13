using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionPlusPlus.IO
{
	public static class DirectoryCloner
	{
		public static void Clone(string source, string destination)
		{
			foreach (string dirPath in Directory.GetDirectories(source, "*", SearchOption.AllDirectories))
				Directory.CreateDirectory(dirPath.Replace(source, destination));

			foreach (string newPath in Directory.GetFiles(source, "*.*", SearchOption.AllDirectories))
				File.Copy(newPath, newPath.Replace(source, destination), true);
		}
	}
}
