using FusionPlusPlus.Engine.Model;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace FusionPlusPlus.Engine.Parser
{
	public class LogItemParser
	{
		public static CultureInfo _fallbackFormatProvider = new CultureInfo("en-US");

		public LogItem Parse(string value)
		{
			value = value.Trim(new char[] { '\r', '\n' });

			var result = new LogItem();
			result.FullMessage = value;
			result.AccumulatedState = LogItem.State.Information;

			var lines = value.Split(LineSeparators, StringSplitOptions.None);

			foreach (var line in lines)
			{
				if (result.TimeStampUtc.Year == 1)
					FindDate(line, d => result.TimeStampUtc = d.ToUniversalTime());

				AddValueIfRelevant(line, "Where-ref.*", s => result.DisplayName = "Where-ref: " + s); // LOG: Where-ref bind. Location =  // LOG: Where-ref-Bindung. Speicherort = 
				AddValueIfRelevant(line, "DisplayName", s => result.DisplayName = s);
				AddValueIfRelevant(line, "AppName", s => result.AppName = s);
				AddValueIfRelevant(line, "AppBase", s => result.AppBase = s);
				AddValueIfRelevant(line, "PrivatePath", s => result.PrivatePath = s);
				AddValueIfRelevant(line, "DynamicPath", s => result.DynamicPath = s);
				AddValueIfRelevant(line, "CacheBase", s => result.CacheBase = s);
				AddValueIfRelevant(line, "Calling Assembly", s => result.CallingAssembly = s);
				AddValueIfRelevant(line, "Aufruf von Assembly", s => result.CallingAssembly = s);

				if (line.Contains("The operation failed.") || line.Contains("Fehler bei diesem Vorgang."))
					result.AccumulatedState = LogItem.State.Error;

				if (result.AccumulatedState == LogItem.State.Error)
					continue;

				if (line.StartsWith("WRN", StringComparison.OrdinalIgnoreCase))
					result.AccumulatedState = LogItem.State.Warning;
				else if (line.StartsWith("ERR", StringComparison.OrdinalIgnoreCase))
					result.AccumulatedState = LogItem.State.Error;
			}

			return result;
		}

		private void AddValueIfRelevant(string content, string keyword, Action<string> setter)
		{
			var match = Regex.Match(content, $@"(?<={keyword}\s*[=|:]).*?$", RegexOptions.IgnoreCase | RegexOptions.Multiline);

			if (match.Success)
			{
				var value = match.Value.Trim().TrimEnd('.');

				if (string.Equals(value, "NULL", StringComparison.OrdinalIgnoreCase))
					return;

				setter(value);
			}
		}

		private bool FindDate(string content, Action<DateTime> setter)
		{
			var match = Regex.Match(content, @"(?<=\().*?@.*?(?=\))");
			if (match.Success)
			{
				var value = match.Value.Trim().Replace("@", "");

				if (DateTime.TryParse(value, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.AssumeLocal, out DateTime result))
				{
					setter(result);
					return true;
				}

				if (DateTime.TryParse(value, _fallbackFormatProvider, DateTimeStyles.AssumeLocal, out DateTime fallbackResult))
				{
					setter(fallbackResult);
					return true;
				}
			}

			return false;
		}

		internal string[] LineSeparators { get; } = new string[] { Environment.NewLine, "\n" };
	}
}
