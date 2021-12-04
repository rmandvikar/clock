using System;

namespace rm.Clock
{
	/// <inheritdoc cref="IClock"/>
	public class Clock : IClock
	{
		public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;

		public DateTimeOffset Now => DateTimeOffset.Now;
	}
}
