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

		internal List<LogItem> Parse(string file)
		{
			var content = FileReader.Read(file);
			var matches = Regex.Match(content, @"(?<=<html><pre>)(\n|\r|\r\n|.)*?(?=</pre></html>)"); // TODO does not match all entries in german logs

			if (!matches.Success)
				return new List<LogItem>();

			return matches
				.Groups.OfType<Group>()
				.Select(g => ItemParser.Parse(g.Value))
				.Where(l => l.IsValid)
				.ToList();
		}

		public LogItemParser ItemParser { get; }

		public IFileReader FileReader { get; }
	}
}
