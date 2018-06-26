using System;

namespace FusionPlusPlus.Model
{
	[System.Diagnostics.DebuggerDisplay("{DisplayName}")]
	public class LogItem
	{
		public string DisplayName { get; set; } = "";

		public string AppName { get; set; } = "";

		public string AppBase { get; set; } = "";

		public string PrivatePath { get; set; } = "";

		public string DynamicPath { get; set; } = "";

		public string CacheBase { get; set; } = "";

		public string CallingAssembly { get; set; } = "";

		public string FullMessage { get; set; } = "";

		public State AccumulatedState { get; set; }

		public DateTime TimeStampUtc { get; set; }

		public DateTime TimeStampLocal => TimeStampUtc.ToLocalTime();

		public bool IsValid => !string.IsNullOrEmpty(DisplayName);

		public enum State
		{
			Information,
			Warning,
			Error
		}
	}
}
