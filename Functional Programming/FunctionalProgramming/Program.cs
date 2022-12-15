using System;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            RunExtensionFunctional01();
        }

        private static void RunExtensionFunctional01()
        {
            var list = Repo.LoadEmployees();

            var q1 = ExtensionFunctional01.Filter(list, e => e.FirstName.ToLowerInvariant() == "ma");
            ExtensionFunctional01.Print(q1, "Employees with first name starts with 'ma'");

            var q2 = ExtensionFunctional01.Filter(list, e => e.LastName.ToLowerInvariant() == "ju");
            ExtensionFunctional01.Print(q2, "Employees with last name starts with 'ju'");

            var q3 = ExtensionFunctional01.Filter(list, e => e.Department.ToLowerInvariant() == "hr");
            ExtensionFunctional01.Print(q3, "Employees in 'HR' department");

            var q4 = ExtensionFunctional01.Filter(list, e => e.Gender.ToLowerInvariant() == "female");
            ExtensionFunctional01.Print(q4, "Female employees");

            var q5 = ExtensionFunctional01.Filter(list, e => e.HireDate.Year == 2018);
            ExtensionFunctional01.Print(q5, "Employees hired in '2018'");

            var q6 = ExtensionFunctional01.Filter(list, e => e.HasPensionPlan);
            ExtensionFunctional01.Print(q6, "Employees with Pension Plan");

            var q7 = ExtensionFunctional01.Filter(list, e => !e.HasHealthInsurance);
            ExtensionFunctional01.Print(q7, "Employees without Health insurance");

            var q8 = ExtensionFunctional01.Filter(list, e => e.Salary == 107000);
            ExtensionFunctional01.Print(q8, "Employees with Salary = $107000");

            var q9 = ExtensionFunctional01.Filter(list, e => e.Salary > 107000);
            ExtensionFunctional01.Print(q9, "Employees with Salary > $107000");

            var q10 = ExtensionFunctional01.Filter(list, e => e.Salary < 107000);
            ExtensionFunctional01.Print(q10, "Employees with Salary < $107000");

            var q11 = ExtensionFunctional01.Filter(list, e => e.Salary < 107000 && e.Gender == "female");
            ExtensionFunctional01.Print(q11, "Employees with Salary < $107000 and female");

        }

    }
}
