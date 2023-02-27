using System;

namespace rm.Clock;

/// <inheritdoc cref="ISystemClock"/>
public class SystemClock : ISystemClock
{
	public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;

	public DateTimeOffset Now => DateTimeOffset.Now;
}
