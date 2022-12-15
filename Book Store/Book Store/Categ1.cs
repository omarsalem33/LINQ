using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    class Categ1 : Book
    {
        private int _sale;

        public Categ1(string title, string author, double price, int quantity, int sale) :base(title,  author,  price,  quantity)
        {
            _sale = sale;
        }

        public override string ToString()
        {
           base.ToString();
           return $"Book is on sale of {this._sale}";
        }

        public override double CalculatePrice()
        {
            this.Price = (Price / 100) * 30;
            return this.Price;
        }
    }
}
