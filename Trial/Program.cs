
using System.Threading;
class Program 
{
	static void Main() 
	{
		Thread t1 = new Thread(DoPrint);
		t1.Start();
		t1.Name = "T1Thread";
		while(true) {
			string inputUser = Console.ReadLine();
			Console.WriteLine(inputUser);
		}
	}
	static void DoPrint() 
	{
		while(true) 
		{
			Thread.Sleep(3000);
			Console.WriteLine(Thread.CurrentThread.Name);
		}
	}
}