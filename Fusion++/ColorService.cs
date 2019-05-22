using FusionPlusPlus.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionPlusPlus
{
	public class ColorService
	{
		public static Color GetColor(LogItem.State state)
		{
			switch (state)
			{
				case LogItem.State.Information:
					return Color.SkyBlue;
				case LogItem.State.Warning:
					return Color.Orange;
				case LogItem.State.Error:
					return Color.Red;
				default:
					return Color.Gray;
			}
		}
	}
}
