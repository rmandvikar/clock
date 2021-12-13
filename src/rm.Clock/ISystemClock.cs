using System;

namespace rm.Clock
{
	/// <summary>
	/// Defines clock methods.
	/// </summary>
	public interface ISystemClock
	{
		DateTimeOffset UtcNow { get; }
		DateTimeOffset Now { get; }
	}
}
