using System;
using System.Reflection;

namespace Demolib
{
    public class Demo
    {
        public static void Trace()
        {
            Console.WriteLine("Tracing....");
            Console.WriteLine($"Executing Assembly:{Assembly.GetExecutingAssembly()}");
            Console.WriteLine($"Calling Assembly:{Assembly.GetCallingAssembly()}");
            Console.WriteLine($"Entry Assembly:{Assembly.GetEntryAssembly()}");

        }
    }

}
