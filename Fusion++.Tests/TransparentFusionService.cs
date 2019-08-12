using FusionPlusPlus.Engine.Model;
using FusionPlusPlus.Engine.Parser;
using NUnit.Framework;
using FluentAssertions;
using System;
using FusionPlusPlus.Engine.Fusion;

namespace FusionPlusPlus.Tests
{
	internal class TransparentFusionService : IFusionService
	{
		public LogMode Mode { get; set; }

		public bool Immersive { get; set; }

		public string LogPath { get; set; }
	}
}
