using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
   abstract class Book
    {
        private string _title;
        private string _author;
        private double _price;
        private int _quantity;
        
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Book(string title, string author, double Price, int quantity)
        {
            _title = title;
            _author = author;
            _price = Price;
            this.Quantity = Quantity;
        }
        public Book ()
        {
            this._title = "NULL";
            this._author = "NULL";
            this._price = 0.0;
            this._quantity = 0;
        }
        public override string ToString()
        {
            return $"Title : {this._title} // Author : {this._author} // Price : {this._price} // Quantity {this._quantity} ";
        }

        public abstract double CalculatePrice();

        internal void Display()
        {
            throw new NotImplementedException();
        }
    }
}
