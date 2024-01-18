using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		Task task = Task.Run(() => {
			Console.WriteLine("Hello from Task 1!");
			Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
			});
		Task continuation = task.ContinueWith(x => {
			Console.WriteLine("Hello from Task 2!");
			Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
			});
		continuation.Wait();
	}
}
