using Shared;
using Shered;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderBy_Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> emps = Repository.LoadEmployees();
            // IOrderedEnumerable<Employee> sortedEmps = emps.OrderBy(e => e.EmployeeNo);
            // sortedEmps.Print("sorted Emps");

            IOrderedEnumerable<Employee> sortedEmps = emps.OrderBy(e => e, new EmployeeComparer());
            sortedEmps.Print("sorted Emps");



        }

    }
}
