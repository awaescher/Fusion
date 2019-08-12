using FusionPlusPlus.Engine.Model;

namespace FusionPlusPlus.Engine.IO
{
	public interface ILogFileService
	{
		string[] Get(LogSource source, string filter = "");
	}
}