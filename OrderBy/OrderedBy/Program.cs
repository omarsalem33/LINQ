using System;
using System.Linq;
using Shered;

namespace OrderedBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apricot", "orange", "banana", "mango","apple", "grape", "strawberry" };
            
            var orderedFruits = fruits.OrderBy(f => f);
            //orderedFruits.Print("Fruits ASC (Method Syntax)");

            var orderedFruitsQ = from f in fruits            // ===> ASC
                                 orderby f
                                 select f;
           // orderedFruitsQ.Print("Fruits ASC (Method Syntax)");


            var orderedFruitsDESC = fruits.OrderByDescending(f => f);
            orderedFruitsDESC.Print("Fruits DESC (Method Syntax)");

            var orderedFruitsDESCQ = from f in fruits            // ===> DESC
                                 orderby f descending
                                 select f;
            orderedFruitsDESCQ.Print("Fruits DESC (Method Syntax)");


        }
    }
}
