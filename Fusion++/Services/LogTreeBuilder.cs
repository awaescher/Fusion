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
