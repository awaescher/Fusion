using FluentAssertions;
using FusionPlusPlus.Engine.Parser;
using NUnit.Framework;
using System.Threading.Tasks;

namespace FusionPlusPlus.Tests
{
	internal class LogFileParserTests
	{
		internal class ParseMethod : LogFileParserTests
		{
			[Test]
			public async Task Returns_Empty_List_If_RegEx_Does_Not_Match()
			{
				var contentToParse = "I'm just a teenage dirtbag, baby!";
				var parser = new LogFileParser(new LogItemParser(), new PathAsContentRoutingFileReader(), new StringAsFileService(contentToParse));
				var items = await parser.ParseAsync();
				items.Count.Should().Be(0);
			}

			[Test]
			public async Task Parses_All_Items_Of_LogFile1()
			{
				var contentToParse = DumpReader.Read("LogFile1.txt");
				var parser = new LogFileParser(new LogItemParser(), new PathAsContentRoutingFileReader(), new StringAsFileService(contentToParse));
				var items = await parser.ParseAsync();
				items.Count.Should().Be(6);
			}
		}
	}
}
