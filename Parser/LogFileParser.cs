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
		public LogFileParser(LogItemParser itemParser)
		{
			ItemParser = itemParser ?? throw new System.ArgumentNullException(nameof(itemParser));
		}

		internal List<LogItem> Parse(string file)
		{
			var content = File.ReadAllText(file, Encoding.UTF8);
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
	}
}
