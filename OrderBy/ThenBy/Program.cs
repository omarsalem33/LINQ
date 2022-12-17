using System;
using System.Linq;
using Shared;
using Shered;

namespace ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = Repository.LoadEmployees();
            var sortedEmps = emp .OrderBy(x => x.Name).ThenBy(x => x.Salary); // then by second sorted;

            sortedEmps.Print("Sorted by Name (ASC)");
             
        }
    }
}
