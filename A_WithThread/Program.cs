using System;
using System.Diagnostics;
using System.Threading;

public static class Program
{
	public static void Main()
	{
		Console.WriteLine("Starting program.");
		var stopwatch = new Stopwatch();
		stopwatch.Start();

		Thread thread1 = new Thread(DoTaskOne);
		Thread thread2 = new Thread(DoTaskTwo);
		thread1.Start();
		thread2.Start();

		stopwatch.Stop();

		Console.WriteLine($"\nProgram complete. Elapsed time: {stopwatch.ElapsedMilliseconds}ms");
	}

	public static void DoTaskOne()
	{
		for(int i = 0; i < 100000; i++) 
		{
			Console.Write('+');
		}
	}

	public static void DoTaskTwo()
	{
		for(int i = 0; i < 100000; i++) 
		{
			Console.Write('-');
		}
	}
}
