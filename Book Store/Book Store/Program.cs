using System;

namespace Book_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Categ1("Goosebumps", "RL Stine", 7000, 6, 50);
            Book b2 = new Categ1("Anamika", "Rs Vm", 5000, 3, 50);
            Book b3 = new Categ2("LightHouse", "Sam Bill", 9000, 2, 2010);
            Book b4 = new Categ2("Ali Baba and sons", "AS Well", 4000, 9, 2020);

            Reciept r = new Reciept();
            Console.WriteLine("1- Categery '1' \n" + "2- Categery '2' \n" + "3- To delete book from cart\n" + "4- do Exit");
            int x, b;
            string s;
            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                if(x == 1)
                {
                    Console.WriteLine("This is Category 1 book!");
                    Console.WriteLine("Please Enter Book Title To Add To Cart : ");
                    s = Console.ReadLine();
                    Console.WriteLine("Pleas Enter Quantity : ");
                    b = Convert.ToInt32(Console.ReadLine());

                    if (s == "Goosebumps")
                    {
                        if (b <= b1.Quantity) {
                            Console.WriteLine(b1.Quantity);
                            r.Books.Add(b1);
                             
                        }
                        else
                            Console.WriteLine("Error!");
                    }
                    else if (s == "Anamika")
                    {
                        if (b <= b2.Quantity)
                            r.Books.Add(b2);
                        else
                            Console.WriteLine("Error!");
                    }
                    else
                        Console.WriteLine("Not is stock!");
                }
                else if(x == 2)
                {
                    Console.WriteLine("This is Category 2 book!");
                    Console.WriteLine("Please Enter Book Title To Add To Cart : ");
                    s = Console.ReadLine();
                    Console.WriteLine("Pleas Enter Quantity : ");
                    b = Convert.ToInt32(Console.ReadLine());

                    if (s == "LightHouse")
                    {
                        if (b <= b3.Quantity)
                            r.Books.Add(b3);
                        else
                            Console.WriteLine("Error!");
                    }
                    else if (s == "Ali Baba and sons")
                    {
                        if (b <= b4.Quantity)
                            r.Books.Add(b4);
                        else
                            Console.WriteLine("Error!");
                    }
                    else
                        Console.WriteLine("Not is stock!");
                }
                else if(x == 3)
                {
                    Console.WriteLine("Enter Bool Title To Remove From Cart : ");
                    s = Console.ReadLine();
                    if (s == "Goosebumps")
                        r.Books.Remove(b1);
                    else if (s == "Anamika")
                        r.Books.Remove(b2);
                    else if (s == "LightHouse")
                        r.Books.Remove(b3);
                    else if(s == "Ali Baba and sons")
                        r.Books.Remove(b4);
                    else
                    {
                        Console.WriteLine("Proceed To Payment !");
                    }
                    
                }
                x++;

            } while(x <= 3);
            r.Display();
        }

        
    }
}
