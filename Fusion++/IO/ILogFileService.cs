using FusionPlusPlus.Model;

namespace FusionPlusPlus.IO
{
	internal interface ILogFileService
	{
		string[] Get(LogSource source, string filter = "");
	}
}