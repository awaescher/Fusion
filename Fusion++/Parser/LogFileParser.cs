using FusionPlusPlus.IO;
using FusionPlusPlus.Model;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FusionPlusPlus.Parser
{
	internal class LogFileParser
	{
		public LogFileParser(LogItemParser itemParser, IFileReader fileReader)
		{
			ItemParser = itemParser ?? throw new System.ArgumentNullException(nameof(itemParser));
			FileReader = fileReader ?? throw new System.ArgumentNullException(nameof(fileReader));
		}

		internal List<LogItem> Parse(string[] files)
		{
			return files.SelectMany(Parse).ToList();
		}

		internal List<LogItem> Parse(string file)
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

		public LogItemParser ItemParser { get; }

		public IFileReader FileReader { get; }
	}
}
