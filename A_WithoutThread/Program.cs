using System;
using System.Diagnostics;

public static class Program
{
	public static void Main()
	{
		//Environment print
		Console.WriteLine(Environment.ProcessorCount);
		//ThreadId
		Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
		Console.WriteLine("Starting program.");
		var stopwatch = new Stopwatch();
		
		stopwatch.Start();
		DoTaskOne();
		DoTaskTwo();
		stopwatch.Stop();

		Console.WriteLine($"\nProgram complete. Elapsed time: {stopwatch.ElapsedMilliseconds}ms");
	}

	public static void DoTaskOne()
	{
		Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
		for(int i = 0; i < 1000; i++) 
		{
			Console.Write('+');
		}
	}

	public static void DoTaskTwo()
	{
		for(int i = 0; i < 1000; i++) 
		{
			Console.Write('-');
		}
	}
}
