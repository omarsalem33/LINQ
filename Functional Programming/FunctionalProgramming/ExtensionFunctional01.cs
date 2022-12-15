using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class ExtensionFunctional01
    {
        public static IEnumerable<Employee> Filter(IEnumerable<Employee> soure , Predicate<Employee> predicate)
        {
            foreach (var emp in soure)
            {
                if(predicate(emp))
                    yield return emp;
            }
        }

        public static void Print<T>(IEnumerable<T> source, string title)
        {
            if (source == null)
                return;
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var emp in source)
                Console.WriteLine(emp);
        }
    }
}
