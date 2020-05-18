using System;
using System.Collections.Generic;
using FusionPlusPlus.Engine.Model;

namespace FusionPlusPlus.Engine.Model
{
	[System.Diagnostics.DebuggerDisplay("{DisplayName}; ItemCount: {Items.Count}")]
	public class AggregateLogItem
	{
		private readonly LogItem _representative;

		public AggregateLogItem(LogItem item)
		{
			_representative = item;
			AccumulatedState = item.AccumulatedState;

			Items = new List<LogItem>();
			Items.Add(item);
		}

		public bool CanAggregate(LogItem other)
		{
			if (_representative == null || other == null)
				return false;

			bool sameName = string.Equals(_representative.DisplayName, other.DisplayName, StringComparison.OrdinalIgnoreCase);
			bool sameCaller = string.Equals(_representative.CallingAssembly, other.CallingAssembly, StringComparison.OrdinalIgnoreCase);
			bool sameTime = Math.Abs((_representative.TimeStampUtc - other.TimeStampUtc).TotalSeconds) <= 3;

			return sameName && sameCaller && sameTime;
		}

		public void AddItem(LogItem item)
		{
			if (AccumulatedState < item.AccumulatedState)
				AccumulatedState = item.AccumulatedState;

			Items.Add(item);
		}

		public string UniqueId => _representative?.UniqueId;

		public string DisplayName => _representative?.DisplayName;

		public string ShortAssemblyName => _representative?.ShortAssemblyName;

		public string AppName => _representative?.AppName;

		public LogItem.State AccumulatedState { get; private set; }

		public DateTime? TimeStampUtc => _representative?.TimeStampUtc;

		public DateTime? TimeStampLocal => _representative?.TimeStampLocal;

		public LogSource? Source => _representative?.Source;

		public string CallingAssembly => _representative?.CallingAssembly;

		public List<LogItem> Items { get; }

		public int ItemCount => Items?.Count ?? 0;

		public bool HasTimeStamp => _representative?.HasTimeStamp ?? false;
	}
}