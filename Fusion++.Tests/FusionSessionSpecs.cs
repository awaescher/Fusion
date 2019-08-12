using FusionPlusPlus.Engine.Model;
using FusionPlusPlus.Engine.Parser;
using NUnit.Framework;
using FluentAssertions;
using System;
using FusionPlusPlus.Engine.Fusion;
using FusionPlusPlus.Engine.IO;

namespace FusionPlusPlus.Tests
{
	internal class FusionSessionSpecs
	{
		[Test]
		public void Session_Sets_Own_Configuration_On_Start_And_Resets_On_End()
		{
			var service = new TransparentFusionService
			{
				Immersive = false,
				LogPath = "old-path",
				Mode = LogMode.Disabled
			};

			var store = new TransparentLogStore("new-path");

			var session = new FusionSession(service, store);

			try
			{
				store.Prepared.Should().BeFalse();

				session.Start();

				store.Prepared.Should().BeTrue();

				// active logging configuration
				service.Immersive.Should().BeTrue();
				service.LogPath.Should().Be("new-path");
				service.Mode.Should().Be(LogMode.All);
			}
			finally
			{
				session.End();

				// back to original values
				service.Immersive.Should().BeFalse();
				service.LogPath.Should().Be("old-path");
				service.Mode.Should().Be(LogMode.Disabled);
			}
		}
	}
}
