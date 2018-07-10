using FluentAssertions;
using FusionPlusPlus.Parser;
using NUnit.Framework;

namespace FusionPlusPlus.Tests
{
	internal class LogFileParserTests
	{
		internal class ParseMethod : LogFileParserTests
		{
			[Test]
			public void Returns_Empty_List_If_RegEx_Does_Not_Match()
			{
				var contentToParse = "I'm just a teenage dirtbag, baby!";
				var parser = new LogFileParser(new StringAsFileService(contentToParse), new LogItemParser(), new PathAsContentRoutingFileReader());
				var items = parser.Parse();
				items.Count.Should().Be(0);
			}

			[Test]
			public void Parses_All_Items_Of_LogFile1()
			{
				var contentToParse = DumpReader.Read("LogFile1.txt");
				var parser = new LogFileParser(new StringAsFileService(contentToParse), new LogItemParser(), new PathAsContentRoutingFileReader());
				var items = parser.Parse();
				items.Count.Should().Be(6);
			}
		}
	}
}
