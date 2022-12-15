using System;

namespace ConsoleApp1
{
    public class Sales : Employee
    {
        private decimal SelesVolume { get; set; }

        private decimal Commission {get; set; }

        public Sales(int id, string name, decimal loggedHours, decimal wage , decimal selesVolume , decimal commission) : base(id, name, loggedHours, wage) 
        {
            this.SelesVolume = selesVolume;
            this.Commission = commission;
        }


        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBouns();
        }

        private decimal CalculateBouns()
        {
            return SelesVolume * Commission;
        }

        public override string ToString()
        {
            return base.ToString() +
            $"\n Bouns :{Math.Round(CalculateBouns(), 2)}" +
            $"\n Net salary : {Math.Round(this.Calculate(), 2)}";
        }
    }

    
}
