using FusionPlusPlus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionPlusPlus.Services
{
	public class LogTreeBuilder
	{
		public List<TreeLogItem> Build(List<LogItem> logItems)
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
				if (itemWithCaller.Item.CallingAssembly.Contains("NSide"))
				{
				}

				itemWithCaller.Parent = ordered.FirstOrDefault(p =>
					string.Equals(p.Item.DisplayName, itemWithCaller.Item.CallingAssembly, StringComparison.OrdinalIgnoreCase)
					&& p.Item.TimeStampUtc >= itemWithCaller.Item.TimeStampUtc);

				if (itemWithCaller.HasParent)
				{
				}
			}

			return ordered;
		}
	}

	[System.Diagnostics.DebuggerDisplay("{Item.DisplayName}; HasParent: {HasParent}")]
	public class TreeLogItem
	{
		public TreeLogItem(LogItem item)
		{
			Item = item;
		}

		public LogItem Item { get; }

		public TreeLogItem Parent { get; internal set; }

		public bool HasParent => Parent != null;
	}
}
