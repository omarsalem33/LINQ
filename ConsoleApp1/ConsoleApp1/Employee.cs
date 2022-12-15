namespace ConsoleApp1
{
    // Inheritance 
    public class Employee
    {
        public const int MinimumLoggedHours = 176;
        public const decimal OverTimeRate = 1.25m;

        public Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        private int Id { get; set; }

        private string Name { get; set; }

        private decimal LoggedHours { get; set; }

        private decimal Wage { get; set; }

        protected virtual decimal Calculate() //i use virtual becuse i will update it for all empolyee and cant use abstruct 
        {
           
            return CalculateBaseSalary() + CalculateOverTime();
        }

        private decimal CalculateBaseSalary ()
        {
            return LoggedHours * Wage;
        }
        private decimal CalculateOverTime ()
        {
            var additionalHours = (LoggedHours - MinimumLoggedHours) > 0 ? LoggedHours - MinimumLoggedHours : 0;
            return additionalHours * OverTimeRate * Wage;
        }


        public override string ToString()
        {
            var type = GetType().ToString().Replace("ConsoleApp1.", "");
            return $"\n {type}"+
                   $"\n ID : {Id}" +
                   $"\n Name : {Name}" +
                   $"\n Logged Hours : {LoggedHours} hrs" +
                   $"\n Wage : {Wage} hr" + 
                   $"\n Base Salary : ${CalculateBaseSalary()}" +
                   $"\n Over Time : ${CalculateOverTime()} ";
        }
    }

    
}
