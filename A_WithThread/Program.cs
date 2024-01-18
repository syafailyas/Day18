using System;
using System.Diagnostics;
using System.Threading;

public static class Program
{
	public static int x;
	public static void Main()
	{
		Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
		Console.WriteLine("Starting program.");
		var stopwatch = new Stopwatch();
		stopwatch.Start();

		Thread thread1 = new Thread(DoTaskOne); //+
		Thread thread2 = new Thread(DoTaskTwo); //-
		thread1.Start();
		thread2.Start();
		thread1.Join();
		thread2.Join();
		stopwatch.Stop();

		Console.WriteLine($"\nProgram complete. Elapsed time: {stopwatch.ElapsedMilliseconds}ms");
	}

	public static void DoTaskOne()
	{
		x++;
		Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
		for(int i = 0; i < 200; i++) 
		{
			Console.Write('+');
		}
	}

	public static void DoTaskTwo()
	{
		x--;
		Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
		for(int i = 0; i < 200; i++) 
		{
			Console.Write('-');
		}
	}
}
