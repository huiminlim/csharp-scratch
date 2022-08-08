using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics; // To use the stopwatch

namespace Learning
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            Console.WriteLine("Running tasks synchronously");
            MethodA();
            MethodB();
            MethodC();
            Console.WriteLine("Synchonous tasks have completed, now asynchronous");
            Task taskC = new(MethodC);
            Task taskB = new(MethodB);
            Task taskA = new(MethodA);
            Task[] tasks = { taskA, taskB, taskC };
            taskC.Start();
            taskB.Start();
            taskA.Start();
            Task.WaitAll(tasks); // Wait for all tasks to complete
        }

        // Method to output thread information
        static void OutputThreadInfo()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine("Thread id: {0}, Priority: {1}, Background: {2}, Name: {3}",
                t.ManagedThreadId, t.Priority, t.IsBackground, t.Name ?? "null");
        }

        // Method A to be invoked
        static void MethodA()
        {
            Console.WriteLine("Starting method A...");
            OutputThreadInfo();
            Thread.Sleep(3000);
            Console.WriteLine("Complete method A");
        }

        // Method B to be invoked
        static void MethodB()
        {
            Console.WriteLine("Starting method B...");
            OutputThreadInfo();
            Thread.Sleep(2000);
            Console.WriteLine("Complete method B");
        }

        // Method C to be invoked
        static void MethodC()
        {
            Console.WriteLine("Starting method C...");
            OutputThreadInfo();
            Thread.Sleep(1000);
            Console.WriteLine("Complete method C");
        }
    }
}
