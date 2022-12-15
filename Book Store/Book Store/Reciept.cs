using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    class Reciept
    {
        private List<Book> _books;
        private double _calculatedPrice;
        public List<Book> Books { get; set;}
        
        public Reciept() 
        {
            this.Books = new List<Book>();
        }
        public void Display()
        {
            int num = 1, j = 1;
            foreach (Book book in _books)
            {
                Console.Write(j + ".");
                j++;
                book.Display();
                num++;
                _calculatedPrice+= book.CalculatePrice();
            }
            Console.WriteLine($"Please Pay {_calculatedPrice}");
        }
    }
}
