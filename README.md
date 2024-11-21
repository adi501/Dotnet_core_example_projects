**How to call async method from sync method in c#**
```
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
    await Task.Delay(5000); // Simulating asynchronous operation
}
```
![image](https://github.com/user-attachments/assets/520e2339-7e81-42da-901d-25710f32753a)
