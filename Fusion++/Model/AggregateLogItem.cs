using System;
using System.Collections.Generic;
using FusionPlusPlus.Model;

namespace FusionPlusPlus.Model
{
	[System.Diagnostics.DebuggerDisplay("{DisplayName}; ItemCount: {Items.Count}")]
	public class AggregateLogItem
	{
		private readonly LogItem _representative;

		public AggregateLogItem(LogItem item)
		{
			_representative = item;

			Items = new List<LogItem>();
			Items.Add(item);
		}

		public void AppendSame(LogItem item)
		{
			Items.Add(item);
		}

		public string UniqueId => _representative?.UniqueId;

		public string DisplayName => _representative?.DisplayName;

		public string ShortAssemblyName => _representative?.ShortAssemblyName;

		public string AppName => _representative?.AppName;

		public LogItem.State? AccumulatedState => _representative?.AccumulatedState;

		public DateTime? TimeStampUtc => _representative?.TimeStampUtc;

		public DateTime? TimeStampLocal => _representative?.TimeStampLocal;

		public LogSource? Source => _representative?.Source;

		public string CallingAssembly => _representative?.CallingAssembly;

		public List<LogItem> Items { get; }
	}
}