var n = 3;

Semaphore semaphore = new Semaphore(1, 2);

Thread thread1 = new Thread(Foo);
Thread thread2 = new Thread(Bar);

thread1.Start();
thread2.Start();

Console.ReadLine();

void Foo()
{

    for (int i = 0; i < n; i++)
    {
        semaphore.WaitOne();
        Console.Write("foo");
        semaphore.Release();
    }

}

void Bar()
{

    for (int i = 0; i < n; i++)
    {
        semaphore.WaitOne();
        Console.Write("bar");
        semaphore.Release();
    }

}