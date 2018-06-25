using System;

namespace FusionPlusPlus.Model
{
	[System.Diagnostics.DebuggerDisplay("{DisplayName}")]
	internal class LogItem
	{
		internal string DisplayName { get; set; } = "";

		internal string AppName { get; set; } = "";

		internal string AppBase { get; set; } = "";

		internal string PrivatePath { get; set; } = "";

		internal string DynamicPath { get; set; } = "";

		internal string CacheBase { get; set; } = "";

		internal string CallingAssembly { get; set; } = "";

		internal string FullMessage { get; set; } = "";

		internal State AccumulatedState { get; set; }

		internal DateTime TimeStampUtc { get; set; }

		internal bool IsValid => !string.IsNullOrEmpty(DisplayName);

		internal enum State
		{
			Information,
			Warning,
			Error
		}
	}
}
