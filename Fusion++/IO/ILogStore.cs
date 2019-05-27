namespace FusionPlusPlus.IO
{

	internal interface ILogStore
	{
		void Prepare();

		string Path { get; }

		string GetLogName(string path);
	}
}
