public class Program
{
	static async Task Main()
	{
		Task<string> task = PrinterA();
		await task;
		Console.WriteLine(task.Result);
		
		await PrinterB();
		Console.WriteLine("Finish");
	}

	static async Task<string> PrinterA()
	{
		Console.WriteLine("Start A");
		await Task.Delay(5000);
		return ("Finish A");
	}

	static async Task PrinterB()
	{
		Console.WriteLine("Start B");
		await Task.Delay(5000);
		Console.WriteLine("Finish B");
	}

	//Start A
	//Finish A
	//Start B
	//Finish B
	//Finish
}
