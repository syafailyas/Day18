﻿CancellationTokenSource cts = new();
CancellationToken token = cts.Token;

Task task = DoWorkAsync(token);

Console.WriteLine("Press 'c' to cancel the operation.");

if (Console.ReadKey().KeyChar == 'c')
{
	cts.Cancel();
}

try
{
	await task;
}

catch (OperationCanceledException)
{
	if (token.IsCancellationRequested)
	{
		Console.WriteLine("Operation canceled.");
	}

	Console.WriteLine("Operation completed.");
}

static async Task DoWorkAsync(CancellationToken token)
{
	for (int i = 0; i < 10; i++)
	{
		if(token.IsCancellationRequested)
		{
			return;
		}

		// token.ThrowIfCancellationRequested();

		Console.WriteLine($"Work in progress: {i * 10}%");

		await Task.Delay(2000, token);
	}
}