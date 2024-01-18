using System;
using System.Diagnostics;

public static class Program
{
	public static void Main()
	{
		//Environment print
		//ThreadId
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
		//Environment print
		//ThreadId
		for(int i = 0; i < 100000; i++) 
		{
			Console.Write('+');
		}
	}

	public static void DoTaskTwo()
	{
		//Environment print
		//ThreadId
		for(int i = 0; i < 100000; i++) 
		{
			Console.Write('-');
		}
	}
}
