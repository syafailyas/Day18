using System;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		Task task1 = Task.Run(() => );
		Task task2 = Task.Run(() => Console.WriteLine("Hello from Task 2!"));
		
		Task.WaitAll(task1, task2);
		
		Console.WriteLine("Finished!");
	}
}
