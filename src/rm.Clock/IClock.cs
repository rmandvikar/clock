using System;

namespace rm.Clock
{
	/// <summary>
	/// Defines clock methods.
	/// </summary>
	public interface IClock
	{
		DateTimeOffset UtcNow { get; }
		DateTimeOffset Now { get; }
	}
}
