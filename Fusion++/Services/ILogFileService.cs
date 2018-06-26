using FusionPlusPlus.Model;

namespace FusionPlusPlus.Services
{
	internal interface ILogFileService
	{
		string[] Get(LogSource source, string filter = "");
	}
}