using System;

namespace FusionPlusPlus.Engine.Model
{
	[System.Diagnostics.DebuggerDisplay("{DisplayName}")]
	public class LogItem
	{
		private string _displayName = "";
		private DateTime _timeStampUtc;

		public string DisplayName
		{
			get { return _displayName; }
			set
			{
				_displayName = value;

				var comma = value?.IndexOf(',') ?? -1;
				if (comma == -1)
					comma = value?.Length ?? -1;

				ShortAssemblyName = comma > -1 ? value.Substring(0, comma) : "";
			}
		}

		public string ShortAssemblyName { get; private set; }

		public string AppName { get; set; } = "";

		public string AppBase { get; set; } = "";

		public string PrivatePath { get; set; } = "";

		public string DynamicPath { get; set; } = "";

		public string CacheBase { get; set; } = "";

		public string CallingAssembly { get; set; } = "";

		public string FullMessage { get; set; } = "";

		public State AccumulatedState { get; set; }

		public DateTime TimeStampUtc
		{
			get => _timeStampUtc;
			set
			{
				_timeStampUtc = value;
				TimeStampLocal = value.ToLocalTime();
			}
		}

		public DateTime TimeStampLocal { get; private set; }

		public bool IsValid => !string.IsNullOrEmpty(DisplayName);

		public bool HasTimeStamp => TimeStampUtc.Year > 1;

		public string UniqueId => DisplayName
			+ " @ "
			+ TimeStampUtc.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK");

		public LogSource Source { get; set; }

		public enum State
		{
			Information,
			Warning,
			Error
		}
	}
}
