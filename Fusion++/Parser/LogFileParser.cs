using FusionPlusPlus.IO;
using FusionPlusPlus.Model;
using FusionPlusPlus.Services;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FusionPlusPlus.Parser
{
	internal class LogFileParser
	{
		public LogFileParser(ILogFileService fileService, LogItemParser itemParser, IFileReader fileReader)
		{
			FileService = fileService ?? throw new System.ArgumentNullException(nameof(fileService));
			ItemParser = itemParser ?? throw new System.ArgumentNullException(nameof(itemParser));
			FileReader = fileReader ?? throw new System.ArgumentNullException(nameof(fileReader));
		}

		internal List<LogItem> Parse()
		{
			var defaultLogs = Parse(FileService.Get(LogSource.Default));
			var nativeLogs = Parse(FileService.Get(LogSource.NativeImage));

			defaultLogs.ForEach(l => l.Source = LogSource.Default);
			nativeLogs.ForEach(l => l.Source = LogSource.NativeImage);

			return defaultLogs.Union(nativeLogs).ToList();
		}

		private List<LogItem> Parse(string[] files)
		{
			return files.SelectMany(Parse).ToList();
		}

		private List<LogItem> Parse(string file)
		{
			var content = FileReader.Read(file);

			var logBlocks = Regex
				.Split(content, "<meta.*<pre>|</pre>.*</html>", RegexOptions.Compiled)
				.Where(s => s?.Length > 0);

			if (!logBlocks.Any())
				return new List<LogItem>();

			return logBlocks
				.Select(block => ItemParser.Parse(block))
				.Where(log => log.IsValid)
				.ToList();
		}

		public ILogFileService FileService { get; }

		public LogItemParser ItemParser { get; }

		public IFileReader FileReader { get; }
	}
}
