using System;
using System.Collections.Generic;
using System.Linq;

namespace FusionPlusPlus.Engine.Model
{
	public class LogTreeBuilder
	{
		public List<TreeLogItem> Build(List<AggregateLogItem> logItems)
		{
			var ordered = logItems
				.OrderBy(i => i.TimeStampUtc)
				.Select(i => new TreeLogItem(i))
				.ToList();

			var itemsWithCallers = ordered
				.Where(i => !string.IsNullOrEmpty(i.CallingAssembly))
				.OrderBy(i => i.CallingAssembly);

			foreach (var itemWithCaller in itemsWithCallers)
			{
				itemWithCaller.Parent = ordered.FirstOrDefault(p =>
					string.Equals(p.DisplayName, itemWithCaller.CallingAssembly, StringComparison.OrdinalIgnoreCase)
					&& p.TimeStampUtc >= itemWithCaller.TimeStampUtc);

				if (itemWithCaller.Parent == null)
					System.Diagnostics.Debug.WriteLine($"Could not find parent \"{itemWithCaller.CallingAssembly}\" for assembly \"{itemWithCaller.DisplayName}\"");
			}

			return ordered;
		}
	}
}
