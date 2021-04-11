using FusionPlusPlus.Engine.Model;
using FusionPlusPlus.Engine.Parser;
using NUnit.Framework;
using FluentAssertions;
using System;

namespace FusionPlusPlus.Tests
{
	internal class LogItemParserTests
	{
		protected LogItemParser _parser;

		[SetUp]
		public void SetUp()
		{
			_parser = new LogItemParser();
		}

		internal class ParseMethod : LogItemParserTests
		{
			[Test]
			public void Interprets_LOG_As_Information()
			{
				var item = _parser.Parse("LOG: ...\r\nLOG: ... \r\nLOG: ...");
				item.AccumulatedState.Should().Be(LogItem.State.Information);
			}

			[Test]
			public void Interprets_WRN_As_Warning()
			{
				var item = _parser.Parse("LOG: ...\r\nWRN: ... \r\nLOG: ...");
				item.AccumulatedState.Should().Be(LogItem.State.Warning);
			}

			[Test]
			public void Interprets_ERR_As_Error()
			{
				var item = _parser.Parse("LOG: ...\r\nERR: ... \r\nLOG: ...");
				item.AccumulatedState.Should().Be(LogItem.State.Error);
			}

			[Test]
			public void Skips_NULL_Literals()
			{
				var item = _parser.Parse("LOG: Cache Base = NULL");
				item.CacheBase.Should().Be("");
			}

			[TestCase("de-DE", "*** Assembly Binder Log Entry  (26.06.2018 @ 22:39:59) ***")]
			[TestCase("en-DE", "*** Assembly Binder Log Entry  (26/06/2018 @ 22:39:59) ***")]
			[TestCase("en-UK", "*** Assembly Binder Log Entry  (6/26/2018 @ 10:39:59 PM) ***")]
			[TestCase("en-US", "*** Assembly Binder Log Entry  (6/26/2018 @ 10:39:59 PM) ***")]
			public void Recognizes_Date_With_Culture(string cultureCode, string lineWithDate)
			{
				System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureCode);
				var item = _parser.Parse(lineWithDate);
				item.TimeStampLocal.Should().Be(new DateTime(2018, 06, 26, 22, 39, 59));
			}
			
			[Test]
			public void Parses_Real_World_Dump_As_Expected()
			{
				var log = DumpReader.Read("LogItem1.txt");
				var item = _parser.Parse(log);

				item.AccumulatedState.Should().Be(LogItem.State.Information);
				item.AppBase.Should().Be("file:///C:/Program Files (x86)/Microsoft Visual Studio/2017/Professional/MSBuild/15.0/Bin/");
				item.AppName.Should().Be("MSBuild.exe");
				item.CacheBase.Should().Be("");
				item.CallingAssembly.Should().Be("(Unknown)");
				item.DisplayName.Should().Be("System.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL");
				item.DynamicPath.Should().Be("");
				item.FullMessage.Length.Should().Be(1424);
				item.IsValid.Should().Be(true);
				item.PrivatePath.Should().Be("");
				item.TimeStampUtc.ToLocalTime().Should().Be(new DateTime(2018, 06, 26, 18, 09, 20));
			}

			/// <summary>
			/// This dump has no ERR tags but shows an english message "The operation failed.",
			/// which should be recognized as error as well
			/// </summary>
			[Test]
			public void Returns_Error_For_Hanselman_Dump_Without_ERR_Tag()
			{
				var log = DumpReader.Read("ScottHanselmanLogExample.txt");
				var item = _parser.Parse(log);

				item.AccumulatedState.Should().Be(LogItem.State.Error);
			}

			/// <summary>
			/// This dump has no ERR tags but shows a german message "Fehler bei diesem Vorgang.",
			/// which should be recognized as error as well
			/// </summary>
			[Test]
			public void Returns_Error_For_German_Dump_Without_ERR_Tag()
			{
				var log = DumpReader.Read("GermanFailedTextWithoutERRTag.txt");
				var item = _parser.Parse(log);

				item.AccumulatedState.Should().Be(LogItem.State.Error);
			}

			[TestCase(@"LOG: Where-ref bind. Location = D:\Develop\GitHub\net472\Microsoft.NET.Build.Extensions.Tasks.dll")]
			[TestCase(@"LOG: Where-ref-Bindung.Speicherort = D:\Develop\GitHub\net472\Microsoft.NET.Build.Extensions.Tasks.dll")]
			public void Includes_WhereRef_Bindings(string whereRefLine)
			{
				var item = _parser.Parse(whereRefLine);
				item.DisplayName.Should().StartWith("Where-ref");
			}
		}
	}
}
