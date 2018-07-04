using FusionPlusPlus.Services;
using System.Collections.Generic;

namespace FusionPlusPlus
{
	public class DiagramViewModel
	{
		public DiagramViewModel(List<TreeLogItem> logs)
		{
			Items = logs;

			Connections = new List<DiagramLink>();

			foreach (var log in logs)
			{
				if (log.HasParent)
					Connections.Add(new DiagramLink() { From = log.Parent.Item.UniqueId, To = log.Item.UniqueId });
			}
		}

		public List<TreeLogItem> Items { get; set; }

		public List<DiagramLink> Connections { get; set; }

		public class DiagramItem
		{
			public int Id { get; set; }
			public string Name { get; set; }
		}

		public class DiagramLink
		{
			public string From { get; set; }
			public string To { get; set; }
		}
	}
}