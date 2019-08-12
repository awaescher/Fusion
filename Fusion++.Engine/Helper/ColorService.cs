using FusionPlusPlus.Engine.Model;
using System.Drawing;

namespace FusionPlusPlus.Engine.Helper
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
