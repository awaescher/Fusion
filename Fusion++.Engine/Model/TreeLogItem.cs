using System;

namespace FusionPlusPlus.Engine.Model
{
	[System.Diagnostics.DebuggerDisplay("{Item.DisplayName}; HasParent: {HasParent}")]
	public class TreeLogItem
	{
		public TreeLogItem(AggregateLogItem item)
		{
			Item = item;
		}

		public TreeLogItem Parent { get; internal set; }

		public bool HasParent => Parent != null;

		public AggregateLogItem Item { get; }

		public string UniqueId => Item?.UniqueId;

		public string DisplayName => Item?.DisplayName;

		public string ShortAssemblyName => Item?.ShortAssemblyName;

		public string AppName => Item?.AppName;

		public LogItem.State? AccumulatedState => Item?.AccumulatedState;

		public DateTime? TimeStampUtc => Item?.TimeStampUtc;

		public DateTime? TimeStampLocal => Item?.TimeStampLocal;

		public LogSource? Source => Item?.Source;

		public string CallingAssembly => Item?.CallingAssembly;
	}
}