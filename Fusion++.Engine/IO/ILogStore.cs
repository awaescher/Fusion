namespace FusionPlusPlus.Engine.IO
{

	public interface ILogStore
	{
		void Prepare();

		string Path { get; }

		string GetLogName(string path);
	}
}
