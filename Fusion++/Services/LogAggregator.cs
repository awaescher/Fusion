using System;
using System.Collections.Generic;
using System.Linq;
using FusionPlusPlus.Model;

namespace FusionPlusPlus
{
	internal class LogAggregator
	{
		public LogAggregator()
		{
		}

		internal List<AggregateLogItem> Aggregate(List<LogItem> logs)
		{
			var result = new List<AggregateLogItem>();

			AggregateLogItem aggregate = null;

			var orderedLogs = logs
				.OrderBy(l => l.DisplayName)
				.ThenBy(l => l.TimeStampUtc)
				.ToList();

			foreach (var log in orderedLogs)
			{
				if (string.Equals(aggregate?.UniqueId, log.UniqueId))
				{
					aggregate.AppendSame(log);
					continue;
				}

				aggregate = new AggregateLogItem(log);
				result.Add(aggregate);
			}

			return result;
		}
	}

	[System.Diagnostics.DebuggerDisplay("{Item.DisplayName}; ItemCount: {Items.Count}")]
	public class AggregateLogItem
	{
		public AggregateLogItem(LogItem item)
		{
			Items = new List<LogItem>();
			Items.Add(item);
		}

		public void AppendSame(LogItem item)
		{
			Items.Add(item);
		}

		public string UniqueId => Items.Count > 0 ? Items[0].UniqueId : "";

		public string DisplayName => Items.Count > 0 ? Items[0].DisplayName : "";

		public string AppName => Items.Count > 0 ? Items[0].AppName : "";

		public LogItem.State AccumulatedState => Items.Count > 0 ? Items[0].AccumulatedState : LogItem.State.Information;

		public DateTime TimeStampUtc => Items.Count > 0 ? Items[0].TimeStampUtc : DateTime.MinValue;

		public DateTime TimeStampLocal => Items.Count > 0 ? Items[0].TimeStampLocal : DateTime.MinValue;

		public string CallingAssembly => Items.Count > 0 ? Items[0].CallingAssembly : "";
		

		public List<LogItem> Items { get; }
	}
}