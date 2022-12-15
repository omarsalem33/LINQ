using System;

namespace ConsoleApp1
{
    public class Maintanence : Employee
    {

        public const decimal HardShip = 100m;
        public Maintanence(int id, string name, decimal loggedHours, decimal wage) :base (id, name , loggedHours ,wage){}

        protected override decimal Calculate()
        {
            return base.Calculate() + HardShip;
        }

        public override string ToString()
        {
            return base.ToString() +
            $"\n Allowance :{Math.Round(HardShip, 2)}" +
            $"\n Net salary : {Math.Round(this.Calculate(), 2)}";
        }
    }

    
}
