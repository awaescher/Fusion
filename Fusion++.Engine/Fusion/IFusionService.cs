using FusionPlusPlus.Engine.Model;

namespace FusionPlusPlus.Engine.Fusion
{
	public interface IFusionService
	{
		LogMode Mode { get; set; }

		bool Immersive { get; set; }

		string LogPath { get; set; }
	}
}
