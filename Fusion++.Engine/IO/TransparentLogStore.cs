namespace FusionPlusPlus.Engine.IO
{
	public class TransparentLogStore : ILogStore
	{
		public TransparentLogStore(string path)
		{
			Path = path;
		}

		public void Prepare()
		{
			Prepared = true;
		}

		public string GetLogName(string path) => path;

		public string Path { get; set; }

		public bool Prepared { get; private set; }
	}
}
