using System;
using System.Threading;

namespace DLTAA.Classes
{
    class Worker
    {
        public void Work()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Worker {Thread.CurrentThread.ManagedThreadId} está trabalhando na etapa {i}");
                Thread.Sleep(1000);
            }
        }
    }

    class Threads
    {
        public static async void Run()
        {
            var worker1 = new Worker();
            var worker2 = new Worker();

            var thread1 = new Thread(worker1.Work);
            var thread2 = new Thread(worker2.Work);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Ambas as threads terminaram de trabalhar.");
        }
    }
}

