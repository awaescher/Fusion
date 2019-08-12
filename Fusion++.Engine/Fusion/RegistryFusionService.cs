using FusionPlusPlus.Engine.Model;
using Microsoft.Win32;
using System;

namespace FusionPlusPlus.Engine.Fusion
{
	public class RegistryFusionService : IFusionService
	{
		private const string FUSION_REGISTRY_PATH = @"SOFTWARE\Microsoft\Fusion";

		private void ResetFusionLogMode()
		{
			using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (var key = hklm.OpenSubKey(FUSION_REGISTRY_PATH, writable: true))
				{
					key.DeleteValue(RegistryValues.ForceLog, throwOnMissingValue: false);
					key.DeleteValue(RegistryValues.LogFailures, throwOnMissingValue: false);
					key.DeleteValue(RegistryValues.EnableLog, throwOnMissingValue: false);
				}
			}
		}

		private void WriteFusionLogMode(LogMode mode)
		{
			ResetFusionLogMode();

			switch (mode)
			{
				case LogMode.Disabled:
					WriteFusionSetting(RegistryValues.EnableLog, 0);
					break;
				case LogMode.Basic:
					WriteFusionSetting(RegistryValues.EnableLog, 1);
					break;
				case LogMode.BindFailures:
					WriteFusionSetting(RegistryValues.LogFailures, 1);
					break;
				case LogMode.All:
					WriteFusionSetting(RegistryValues.ForceLog, 1);
					break;
			}
		}

		private LogMode DetermineLogMode()
		{
			if (Convert.ToBoolean(ReadFusionSetting(RegistryValues.ForceLog, 0)))
				return LogMode.All;

			if (Convert.ToBoolean(ReadFusionSetting(RegistryValues.LogFailures, 0)))
				return LogMode.BindFailures;

			var enabled = Convert.ToBoolean(ReadFusionSetting(RegistryValues.EnableLog, 0));

			return enabled ? LogMode.Basic : LogMode.Disabled;
		}

		private void WriteFusionSetting<T>(string settingName, T value)
		{
			using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (var key = hklm.OpenSubKey(FUSION_REGISTRY_PATH, writable: true))
				{
					key.SetValue(settingName, value);
				}
			}
		}

		private T ReadFusionSetting<T>(string settingName, T defaultValue)
		{
			using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (var key = hklm.OpenSubKey(FUSION_REGISTRY_PATH))
				{
					return (T)(key?.GetValue(settingName) ?? defaultValue);
				}
			}
		}

		public LogMode Mode
		{
			get => DetermineLogMode();
			set => WriteFusionLogMode(value);
		}

		public string LogPath
		{
			get => ReadFusionSetting(RegistryValues.LogPath, "");
			set => WriteFusionSetting(RegistryValues.LogPath, value);
		}

		public bool Immersive
		{
			get => Convert.ToBoolean(ReadFusionSetting(RegistryValues.LogImmersive, 0));
			set => WriteFusionSetting(RegistryValues.LogImmersive, value ? 1 : 0);
		}

		private static class RegistryValues
		{
			public static string LogPath { get; } = "LogPath";

			public static string LogImmersive { get; } = "LogImmersive";

			public static string ForceLog { get; } = "ForceLog";

			public static string LogFailures { get; } = "LogFailures";

			public static string EnableLog { get; } = "EnableLog";
		}
	}
}