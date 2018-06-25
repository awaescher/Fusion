using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionPlusPlus
{
	internal interface IFusionService
	{
		LogMode Mode { get; set; }

		bool Immersive { get; set; }

		string LogPath { get; set; }
	}
}
