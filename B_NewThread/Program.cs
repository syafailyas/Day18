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

		Console.WriteLine("Core :" + Environment.ProcessorCount);
		Console.WriteLine("Main Thread:" + Thread.CurrentThread.ManagedThreadId);
		Thread thread1 = new Thread(DoTaskOne);
		Thread thread2 = new Thread(DoTaskTwo);
		Thread thread3 = new Thread(DoTaskOne);
		Thread thread4 = new Thread(DoTaskTwo);
		
		thread1.Start();
		thread2.Start();
		thread3.Start();
		thread4.Start();
		
		thread1.Join();
		thread2.Join();
		thread3.Join();
		thread4.Join();

		stopwatch.Stop();

		Console.WriteLine($"\nProgram complete. Elapsed time: {stopwatch.ElapsedMilliseconds}ms");
	}

	public static void DoTaskOne()
	{
		for(int i = 0; i < 100; i++) 
		{
			Thread.Sleep(1);
		}
	}

	public static void DoTaskTwo()
	{
		for(int i = 0; i < 100; i++) 
		{
			Thread.Sleep(1);
		}
	}
}
