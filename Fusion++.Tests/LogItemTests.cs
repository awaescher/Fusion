using FusionPlusPlus.Engine.Model;
using FusionPlusPlus.Engine.Parser;
using NUnit.Framework;
using FluentAssertions;
using System;

namespace FusionPlusPlus.Tests
{
	internal class LogItemTests
	{
		internal class ShortAssemblyNameProperty
		{
			[Test]
			public void Returns_Empty_String_For_A_DisplayName_Null()
			{
				var item = new LogItem();
				item.DisplayName = null;
				item.ShortAssemblyName.Should().Be("");
			}

			[Test]
			public void Returns_Empty_String_For_An_Empty_DisplayName()
			{
				var item = new LogItem();
				item.DisplayName = "";
				item.ShortAssemblyName.Should().Be("");
			}

			[Test]
			public void Returns_Full_DisplayName_If_It_Does_Not_Contain_Any_Commas()
			{
				var item = new LogItem();
				item.DisplayName = "Fusion.TestAssembly";
				item.ShortAssemblyName.Should().Be("Fusion.TestAssembly");
			}

			[Test]
			public void Returns_The_DisplayName_To_The_Comma()
			{
				var item = new LogItem();
				item.DisplayName = "Fusion.TestAssembly, PublicKeyToken=47110815";
				item.ShortAssemblyName.Should().Be("Fusion.TestAssembly");
			}

			[Test]
			public void Returns_The_DisplayName_To_The_First_Comma_If_Multiple()
			{
				var item = new LogItem();
				item.DisplayName = "Fusion.TestAssembly, Version=18.1.3.0, Culture=neutral, PublicKeyToken=47110815";
				item.ShortAssemblyName.Should().Be("Fusion.TestAssembly");
			}
		}
	}
}
