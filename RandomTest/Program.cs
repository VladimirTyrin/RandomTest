using System;
using System.Diagnostics;
using System.Threading;

namespace RandomTest
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			while (true)
			{
				var currentValue = -1;
				var counter = 0;
				var sw = Stopwatch.StartNew();
				
				while (true)
				{
					var random = new Random();
					var next = random.Next(1, 100);

					if (currentValue < 0)
					{
						currentValue = next;
						continue;
					}
					if (next != currentValue)
						break;

					counter++;
				}
				Console.WriteLine($"{counter} duplicates ({(double) sw.ElapsedTicks * 1000 / Stopwatch.Frequency} ms)");
				Thread.Sleep(500);
			}
		}
	}
}
