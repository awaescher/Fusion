using FusionPlusPlus.Model;
using FusionPlusPlus.Parser;
using NUnit.Framework;
using FluentAssertions;
using System;

namespace FusionPlusPlus.Tests
{
	internal class AggregateLogItemTests
	{
		internal class AddItemMethod
		{
			[TestCase(LogItem.State.Information, LogItem.State.Information, LogItem.State.Information)]
			[TestCase(LogItem.State.Information, LogItem.State.Warning, LogItem.State.Warning)]
			[TestCase(LogItem.State.Information, LogItem.State.Error, LogItem.State.Error)]
			[TestCase(LogItem.State.Warning, LogItem.State.Information, LogItem.State.Warning)]
			[TestCase(LogItem.State.Warning, LogItem.State.Warning, LogItem.State.Warning)]
			[TestCase(LogItem.State.Warning, LogItem.State.Error, LogItem.State.Error)]
			[TestCase(LogItem.State.Error, LogItem.State.Information, LogItem.State.Error)]
			[TestCase(LogItem.State.Error, LogItem.State.Warning, LogItem.State.Error)]
			[TestCase(LogItem.State.Error, LogItem.State.Error, LogItem.State.Error)]
			public void Aggregates_The_State_To_The_Worst_Case(LogItem.State firstState, LogItem.State secondState, LogItem.State expectedState)
			{
				var aggregate = new AggregateLogItem(new LogItem() { AccumulatedState = firstState });
				aggregate.AddItem(new LogItem() { AccumulatedState = secondState });
				aggregate.AccumulatedState.Should().Be(expectedState);
			}
		}

		internal class CanAggregateMethod
		{
			[Test]
			public void Ignores_Casing()
			{
				var first = new LogItem() { DisplayName = "AnyAssembly" };
				var second = new LogItem() { DisplayName = "anyassembly" };
				new AggregateLogItem(first).CanAggregate(second).Should().BeTrue();
			}

			[Test]
			public void Does_Not_Allow_Null()
			{
				var first = new LogItem();
				LogItem second = null;
				new AggregateLogItem(first).CanAggregate(second).Should().BeFalse();
			}

			[Test]
			public void Returns_True_For_Same_TimeStamp()
			{
				var first = new LogItem() { TimeStampUtc = new DateTime(2018, 12, 12, 08, 40, 30) };
				var second = new LogItem() { TimeStampUtc = new DateTime(2018, 12, 12, 08, 40, 30) };
				new AggregateLogItem(first).CanAggregate(second).Should().BeTrue();
			}

			[Test]
			public void Returns_True_For_Up_To_3_Seconds_Variance_In_TimeStamp()
			{
				var first = new LogItem() { TimeStampUtc = new DateTime(2018, 12, 12, 08, 40, 30) };
				var second = new LogItem() { TimeStampUtc = new DateTime(2018, 12, 12, 08, 40, 33) };
				new AggregateLogItem(first).CanAggregate(second).Should().BeTrue();
			}

			[Test]
			public void Returns_False_For_More_Than_3_Seconds_Variance_In_TimeStamp()
			{
				var first = new LogItem() { TimeStampUtc = new DateTime(2018, 12, 12, 08, 40, 30, 0000) };
				var second = new LogItem() { TimeStampUtc = new DateTime(2018, 12, 12, 08, 40, 33, 0001) };
				new AggregateLogItem(first).CanAggregate(second).Should().BeFalse();
			}
		}
	}
}
