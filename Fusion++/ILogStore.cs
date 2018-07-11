using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionPlusPlus
{

	internal interface ILogStore
	{
		void Prepare();

		string Path { get; }
	}
}
