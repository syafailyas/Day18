﻿namespace AsynchronousProgramming
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Main Method Started......");

			SomeMethod();

			Console.WriteLine("Main Method End");
			Console.ReadLine();
			Console.WriteLine("Main Method End");
		}

		public async static void SomeMethod()
		{
			Console.WriteLine("Some Method Started......");

			//Thread.Sleep(TimeSpan.FromSeconds(10));
			await Task.Delay(TimeSpan.FromSeconds(4));
			Console.WriteLine("\n");
			Console.WriteLine("Some Method End");
		}
	}
}

