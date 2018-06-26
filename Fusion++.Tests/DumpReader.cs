using System.IO;
using System.Reflection;

namespace FusionPlusPlus.Tests
{
	internal static class DumpReader
	{
		internal static string Read(string fileName)
		{
			var assembly = Assembly.GetExecutingAssembly();
			var resourceName = "FusionPlusPlus.Tests.Dumps." + fileName;

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			using (StreamReader reader = new StreamReader(stream))
				return reader.ReadToEnd();
		}
	}
}
