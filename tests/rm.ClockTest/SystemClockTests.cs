using NUnit.Framework;

namespace rm.Clock
{
	[TestFixture]
	public class SystemClockTests
	{
		[Test]
		public void Verify_UtcNow()
		{
			var clock = new SystemClock();
			DateTimeOffset utcNow = clock.UtcNow;
			Console.WriteLine($"type:          {utcNow.GetType()}");
			Console.WriteLine($"utcNow:        {utcNow}");
			Console.WriteLine($"UtcDateTime:   {utcNow.UtcDateTime}");
			Console.WriteLine($"LocalDateTime: {utcNow.LocalDateTime}");
		}

		[Test]
		public void Verify_Now()
		{
			var clock = new SystemClock();
			DateTimeOffset now = clock.Now;
			Console.WriteLine($"type:          {now.GetType()}");
			Console.WriteLine($"now:           {now}");
			Console.WriteLine($"UtcDateTime:   {now.UtcDateTime}");
			Console.WriteLine($"LocalDateTime: {now.LocalDateTime}");
		}
	}
}
