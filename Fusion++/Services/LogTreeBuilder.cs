using FusionPlusPlus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionPlusPlus.Services
{
	internal class LogTreeBuilder
	{
		public List<TreeLogItem> Build(List<AggregateLogItem> logItems)
		{
			var ordered = logItems
				.OrderBy(i => i.TimeStampUtc)
				.Select(i => new TreeLogItem(i))
				.ToList();

			var itemsWithCallers = ordered
				.Where(i => !string.IsNullOrEmpty(i.Item.CallingAssembly))
				.OrderBy(i => i.Item.CallingAssembly);

			foreach (var itemWithCaller in itemsWithCallers)
			{
				itemWithCaller.Parent = ordered.FirstOrDefault(p =>
					string.Equals(p.Item.DisplayName, itemWithCaller.Item.CallingAssembly, StringComparison.OrdinalIgnoreCase)
					&& p.Item.TimeStampUtc >= itemWithCaller.Item.TimeStampUtc);
			}

			return ordered;
		}
	}

	[System.Diagnostics.DebuggerDisplay("{Item.DisplayName}; HasParent: {HasParent}")]
	public class TreeLogItem
	{
		public TreeLogItem(AggregateLogItem item)
		{
			Item = item;
		}

		public AggregateLogItem Item { get; }

		public TreeLogItem Parent { get; internal set; }

		public bool HasParent => Parent != null;
	}
}
