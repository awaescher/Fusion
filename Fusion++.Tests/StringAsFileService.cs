using FusionPlusPlus.Engine.IO;
using FusionPlusPlus.Engine.Model;

namespace FusionPlusPlus.Tests
{
	internal class StringAsFileService : ILogFileService
	{
		private readonly string[] _stringsAsFiles;

		public StringAsFileService(params string[] stringsAsFiles)
		{
			_stringsAsFiles = stringsAsFiles;
		}

		public string[] Get(LogSource source, string filter = "")
		{
			return source == LogSource.Default ? _stringsAsFiles : new string[0];
		}
	}
}