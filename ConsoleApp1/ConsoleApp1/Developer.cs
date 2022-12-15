using System;

namespace ConsoleApp1
{
    public class Developer : Employee
    {
        public const decimal Comission = 0.03m;
        private bool TaskCompleted { get; set; }
        public Developer(int id, string name, decimal loggedHours, decimal wage , bool taskCompleted) : base(id, name, loggedHours, wage)
        {
            this.TaskCompleted = taskCompleted;
        }

        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBouns();
        }

        private decimal CalculateBouns()
        {
            if(TaskCompleted)
                return base.Calculate() * Comission;
            return 0; 
        }

        public override string ToString()
        {
            return base.ToString() +
            $"\n Task Completed : {(TaskCompleted ? "YES" : "NO") }" +
            $"\n Bouns :{Math.Round(CalculateBouns(), 2)}" +
            $"\n Net salary : {Math.Round(this.Calculate(), 2)}";
        }
    }

    
}
