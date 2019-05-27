using FusionPlusPlus.Model;

namespace FusionPlusPlus.Fusion
{
	internal interface IFusionService
	{
		LogMode Mode { get; set; }

		bool Immersive { get; set; }

		string LogPath { get; set; }
	}
}
