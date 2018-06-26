using FluentAssertions;
using FusionPlusPlus.Parser;
using NUnit.Framework;

namespace FusionPlusPlus.Tests
{
	internal class LogFileParserTests
	{
		protected LogFileParser _parser;

		[SetUp]
		public void SetUp()
		{
			_parser = new LogFileParser(new LogItemParser(), new PathAsContentRoutingFileReader());
		}

		public class ParseMethod : LogFileParserTests
		{
			[Test]
			public void Returns_Empty_List_If_RegEx_Does_Not_Match()
			{
				var items = _parser.Parse("I'm just a teenage dirtbag, baby!");
				items.Count.Should().Be(0);
			}

			[Test]
			public void Does()
			{
				var items = _parser.Parse(DumpReader.Read("LogFile1.txt"));
				items.Count.Should().Be(6);
			}
		}
	}
}
