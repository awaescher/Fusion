using FusionPlusPlus.Model;

namespace FusionPlusPlus.Services
{
	internal interface IFusionService
	{
		LogMode Mode { get; set; }

		bool Immersive { get; set; }

		string LogPath { get; set; }
	}
}
