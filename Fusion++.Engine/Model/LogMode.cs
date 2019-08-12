namespace FusionPlusPlus.Engine.Model
{
	public enum LogMode
	{
		/// <summary>
		/// Registry: -no values-
		/// FusionUI: Disabled
		/// </summary>
		Disabled = 0,

		/// <summary>
		/// Registry: EnableLog (0/1)
		/// FusionUI: Log in exception text
		/// </summary>
		Basic = 1,

		/// <summary>
		/// Registry: LogFailures (0/1)
		/// FusionUI: Log bind failures to disk
		/// </summary>
		BindFailures = 2,

		/// <summary>
		/// Registry: ForceLog (0/1)
		/// FusionUI: Log all bindings to disk
		/// </summary>
		All = 3
	}
}