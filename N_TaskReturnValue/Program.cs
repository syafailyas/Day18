using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		int x = 3;
		int y = 4;
		Task<int> task = Task.Run(()=>Add(x,y));

		int result = task.Result;
		Console.WriteLine($"Result: {result}");
	}
	
	static int Add(int a, int b)
	{
		return a + b;
	}
}
