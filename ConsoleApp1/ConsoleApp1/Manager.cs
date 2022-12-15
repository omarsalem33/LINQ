using System;

namespace ConsoleApp1
{
    public class Manager : Employee
    {

        public const decimal AllowanceRate = 0.05m;
        public Manager(int id, string name, decimal loggedHours, decimal wage) :base (id, name, loggedHours, wage) {}
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateAllowance();
        }

        private decimal CalculateAllowance()
        {
            return AllowanceRate * base.Calculate();
        }

        public override string ToString()
        {
            return base.ToString() +
            $"\n Allowance :{Math.Round(CalculateAllowance(),2)}" +
            $"\n Net salary : {Math.Round (this.Calculate() , 2) }";
        }
    }

    
}
