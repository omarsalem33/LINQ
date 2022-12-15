using System;
using System.Threading;
using System.Threading.Tasks;

namespace PoolThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1 -- > Using ThreadPool 
            ThreadPool.QueueUserWorkItem(new WaitCallback(print));
            Console.WriteLine("------------------");
            //method 2 --> Usinfg Task
            Task.Run(Print);

            var e = new Emp { Rate = 100, TotalHours = 8 };

            ThreadPool.QueueUserWorkItem(new WaitCallback(CalcSalary), e);
            Console.WriteLine(e.TotalSalary);
            Console.ReadKey();
        }

        private static void CalcSalary(object emp)
        {
            var e = emp as Emp;
            if (e is null)
                return;
            e.TotalSalary = e.TotalHours * e.Rate;
            Console.WriteLine($"Total salary {e.TotalSalary}");
        }

        private static void Print()
        {
            Console.WriteLine($"Thread Id : {Thread.CurrentThread.ManagedThreadId}" + $"\nThread Name : {Thread.CurrentThread.Name}");
            Console.WriteLine($"Is Pooled Thread {Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"Background {Thread.CurrentThread.IsBackground}");
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"Cycle {i + 1}");
        }

        private static void print(object state)
        {
            Console.WriteLine($"Thread Id : {Thread.CurrentThread.ManagedThreadId}" + $"\nThread Name : {Thread.CurrentThread.Name}");
            Console.WriteLine($"Is Pooled Thread {Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"Background {Thread.CurrentThread.IsBackground}");
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"Cycle {i + 1}");
        }
        class Emp
        {
            public decimal TotalHours { get; set; }
            public decimal Rate { get; set; }
            public decimal TotalSalary { get; set; }

        }
    }
}
