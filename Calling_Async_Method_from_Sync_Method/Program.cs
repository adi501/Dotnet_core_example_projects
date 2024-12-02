
SynchronousWork();
Console.ReadLine();

void SynchronousWork()
{
    Console.WriteLine("Synchronous work started...");
    Task.Run(async () =>
    {
        await AsynchronousWorkAsync();
        Console.WriteLine("Asynchronous work completed.");
    }).Wait();
    Console.WriteLine("Synchronous work completed.");
}

async Task AsynchronousWorkAsync()
{
    Console.WriteLine("Asynchronous work started...");
    await Task.Delay(2000); // Simulating asynchronous operation
}
