
AsynchronousWorkAsync();
Console.ReadLine();

void SynchronousWork()
{
    Console.WriteLine("Synchronous work s tarted...");
    Task.Delay(5000);
    Console.WriteLine("Synchronous work completed.");
}

async Task AsynchronousWorkAsync()
{
    Console.WriteLine("Asynchronous work started...");
    SynchronousWork();
    await Task.Delay(5000); // Simulating asynchronous operation
    Console.WriteLine("Asynchronous work completed.");
}
