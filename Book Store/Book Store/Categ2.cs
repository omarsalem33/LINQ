using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    class Categ2:Book
    {
        private int _edition;
        public int Edition { get; set; }

        public Categ2(string title, string author, double price, int quantity, int _edition) : base(title, author, price, quantity)
        {
            this.Edition = _edition;
        }

        public override string ToString()
        {
            base.ToString();
            return $"Book is of Edition : {this._edition} Price Book is :{this.CalculatePrice()}";
        }

        public override double CalculatePrice()
        {
            this.Price = Price;
            return this.Price;
        }
    }
}
