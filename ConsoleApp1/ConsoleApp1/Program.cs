using Demolib;
using System;
using Humanizer;
using System.IO;
using System.Data;
using System.Net.Http;
using System.Xml.Linq;
using System.Threading;
using System.Reflection;
using System.Collections;
using System.IO.Compression;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace ConsoleApp1
{
    public delegate void helperDeleget(decimal x, decimal y);
    public class Program
    {
        static void Main(string[] args)
        {
            //Date date = new Date(29, 2, 2000);
            #region indexer
            //Console.WriteLine(date.GetDate());
            //int[,] mat = new int[,] 
            //{
            //    {1, 2, 3},
            //    {4, 5, 6}
            //} ;

            //var  mat2 = new IP(mat) ;
            //Console.WriteLine(mat2[1,2]);
            #endregion
            #region deleget
            //    var emps = new Employee[]
            //    {
            //        new Employee{Id = 1 , Name = "omar salem" , Gender = "M" ,TotelSalary = 15000m},
            //        new Employee{Id = 2 , Name = "ahmed salem" , Gender = "M" ,TotelSalary = 6000m},
            //        new Employee{Id = 3 , Name = "omar Mohamed" , Gender = "M" ,TotelSalary = 3000m},
            //        new Employee{Id = 4 , Name = "Nada salem" , Gender = "F" ,TotelSalary = 20000m},
            //        new Employee{Id = 5 , Name = "doaa salem" , Gender = "F" ,TotelSalary = 25000m},
            //        new Employee{Id = 6 , Name = "amr salem" , Gender = "M" ,TotelSalary = 2000m},
            //        new Employee{Id = 7 , Name = "Eslam ahmed" , Gender = "M" ,TotelSalary = 1500m},

            //    };
            //    var report = new Report();
            //    report.ProcessEmployee(emps, "Sales >= 15000",e => e.TotelSalary >= 15000m); // e => e.TotelSalary >= 15000m -> labmda expretion
            //    report.ProcessEmployee(emps, "Sales < 15000 and sales >= 3000", e => e.TotelSalary < 15000m && e.TotelSalary >= 3000m);
            //    report.ProcessEmployee(emps, "Sales < 3000", e=> e.TotelSalary < 3000m);
            #endregion
            #region Multi Deleget
            //RectnagleHelper helper = new RectnagleHelper();
            //helperDeleget help;
            //help = helper.GetArea;
            //help += helper.GetPerimeter;

            //help(10, 10);

            #endregion
            #region Event
            //var stock = new Stock("Amazon");
            //stock.Price = 200;
            //stock.StockChanged += Stock_StockChanged;

            ////Console.WriteLine($"Stock Befor Change price ${stock.Price}");
            ////stock.changeStockByPercent(0.10m);
            ////Console.WriteLine($"Stock After Change price ${stock.Price}");
            //stock.changeStockByPercent(0.20m);
            //stock.changeStockByPercent(-0.40m);
            //stock.changeStockByPercent(0.00m);
            #endregion
            #region Struct
            //DigitalSize size = new DigitalSize(60000);
            //Console.WriteLine(size.Bit);
            //Console.WriteLine(size.Byte);
            //Console.WriteLine(size.KB);
            //Console.WriteLine(size.MB);
            //Console.WriteLine(size.GB);
            #endregion
            #region Inheritance
            //Manager m = new Manager(1 , "Omar" , 180 ,10);
            //Maintanence ms = new Maintanence (2 , "salem" , 182 ,8 );
            //Sales s = new Sales (3 ,"Hala" , 170 , 9,  0.10m , 10000 );
            //Developer d = new Developer (4,"Hoda",150, 11,  true);
            //Employee[] emp = { m, ms, s, d };
            //foreach(Employee e in emp)
            //{
            //    Console.WriteLine("\n-------------------------------------");
            //    Console.WriteLine(e);
            //}

            #endregion
            #region Interface
            //Cashier c = new Cashier(new MasterCard());
            //c.CheckOut(999999.99m );
            #endregion
            #region Exceptions
            //var Delivery = new Delivery { Id = 1, Name = "Omar", Address = "Alex" };
            //var service = new DilveryService();
            //service.start(Delivery);
            //Console.WriteLine(Delivery);
            #endregion
            #region Enumerators
            //var ints = new FiveIntegers(1, 2, 3, 4, 5);
            //foreach(var i in ints)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion
            #region IComparable
            //// to sort obj use a Icomparable;
            //var Temps = new List<Tempreture>();
            //Random rnd = new Random();
            //for(int i = 0; i < 100; i++)
            //{
            //    Temps.Add(new Tempreture(rnd.Next(-30, 50)));
            //}
            //Temps.Sort();
            // foreach(Tempreture temp in Temps)
            //{
            //    Console.WriteLine(temp.Value);
            //}
            #endregion
            #region XML Documentation
            //do
            //{
            //    Console.Write("Name : ");
            //    var Name = Console.ReadLine();
            //    Console.Write("Hire Date : ");
            //    DateTime?hireDate = null;
            //    if(DateTime.TryParse(Console.ReadLine() , out DateTime hDate))
            //    {
            //        hireDate = hDate;
            //    }
            //    var empID = Genaretor.GenereteId(Name, hireDate);
            //    var empPass = Genaretor.GenerateRandomPassword(8);

            //    Console.WriteLine("{" + $" \n Id : {empID} , \n Name : {Name} , \n Hire Date : {hireDate} , \n Password : {empPass }" + "\n}");
            //} while (true);
            #endregion
            #region Extentions
            //Pizza p = new Pizza();
            //p.AddDough("Thin")
            // .AddSauce()
            // .AddCheeze(true)
            // .AddToppings("Black olives", 3.5m);
            //Console.WriteLine(p);
            #endregion
            #region Assemblies
            ////Demo.Trace();
            //var type = typeof(Program);
            //var assembly = type.Assembly;
            //Console.WriteLine($"Full Name : {assembly.FullName}");
            //Console.WriteLine($"Location : {assembly.Location}");
            #endregion
            #region List and Dictionaries
            //var EG = new Country { ISOCode = "EGY", Name = "EGYPT" };
            //var JOR = new Country { ISOCode = "JOR", Name = "JORDAN" };

            //Country[] County =
            //{
            //    EG ,
            //    JOR,
            //};
            //// constructor
            //List<Country> countries = new List<Country>(); 
            //// properties 

            ////method
            //countries.Add(new Country { ISOCode = "BRA", Name = "BRASIL" }); // O(1)
            //countries.AddRange(County); // O(1)

            //countries.Insert(1, new Country { ISOCode = "FRA", Name = "FRANCE" }); //O(N)
            //countries.Insert(2, new Country { ISOCode = "ENG", Name = "ENGLAND" }); //O(N)
            //countries.RemoveAt(2);// O(N)
            //countries.RemoveAll(x => x.Name.EndsWith("CE"));
            //countries.Remove ( new Country { ISOCode = "ENG", Name = "ENGLAND" });
            //prinList(countries);

            //---------------------------------------------------------------------------------------------
            //string s =
            //    "omar salem" +
            //    "abdall nasser" +
            //    "hisham salem" +
            //    "amr hany" +
            //    "ali salah" +
            //    "messi";
            //Dictionary<char, List<string>> letterDictionary = new Dictionary<char, List<string>>();
            //foreach(var word in s.Split())
            //{
            //    foreach(var ch in word)
            //    {
            //        if (!letterDictionary.ContainsKey(ch))
            //        {
            //            letterDictionary.Add(ch, new List<string>());
            //        }
            //        else
            //        {
            //            letterDictionary[ch].Add(word);
            //        }
            //    }
            //}

            //foreach(var i in letterDictionary)
            //{
            //    Console.Write($"KEY : {i.Key}");
            //    foreach (var item in i.Value)
            //    {
            //        Console.WriteLine($"\t\t  VAL {item}");
            //    }
            //}

            #endregion
            #region Stack and Queue


            // Stack
            /* stack is a data structure use LIFO (Last In First Out) 
             * queue is a data structure use FIFO (First In First Out)
             * both not use indexing and faster than List and Dictionary
             */
            /*
            Stack<Command> undo = new Stack<Command>();
            Stack<Command> redo = new Stack<Command>();
            string s;
            while (true)
            {
                Console.Write("URL ('Exit' to quit):");
                s = Console.ReadLine().ToLower();
                if (s == "exit")
                    break;
                else if (s == "back")
                {
                    if (undo.Count > 0)
                    {
                        var item = undo.Pop();
                        redo.Push(item);
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty");
                        continue;
                    }
                }
                else if (s == "forward")
                {
                    if (redo.Count > 0)
                    {
                        var item = redo.Pop();
                        undo.Push(item);
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty");
                        continue;
                    }
                }
                else
                {
                    //add url to undo 
                    undo.Push(new Command(s));
                }
                Console.Clear();
                PrintStack("Back", undo);
                PrintStack("Forward", redo);
            }

            // ------------------------------------------------------------------------------------------------
            // Queue
            Queue<PrintJop> printJobs = new Queue<PrintJop>();
            printJobs.Enqueue(new PrintJop("decomentation.docx", 2));
            printJobs.Enqueue(new PrintJop("decomentation.xlx", 4));
            printJobs.Enqueue(new PrintJop("decomentation.pdf", 3));
            printJobs.Enqueue(new PrintJop("decomentation.txt", 1));
            Random rnd = new Random();
            while(printJobs.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                var job = printJobs.Dequeue();
                Console.WriteLine($"printing..... {job}");
                System.Threading.Thread.Sleep(rnd.Next(1, 3) * 1000);

            }

            */
            #endregion
            // using ==> try catch
            #region Dispose
            //(not recommended)
            /*
            CurrencyService currencyService = new CurrencyService();
            var res = currencyService.GetCurrencies();
            currencyService.Dispose();
            Console.WriteLine(res);*/

            // (recommended)
            //using (CurrencyService currencyService = new CurrencyService())
            //{
            //    var res = currencyService.GetCurrencies();
            //    Console.WriteLine(res);
            //}
            #endregion
            #region Stream
            //Example01();
            //Example02();
            //Example03();
            // Example04(); 
            #endregion
            #region Decorator
            //using (var stream = File.Create("data.bin"))
            //{
            //    using (var ds = new DeflateStream(stream, CompressionMode.Compress))
            //    {
            //        ds.WriteByte(65);
            //        ds.WriteByte(66);
            //    }
            //}
            //using (var stream = File.OpenRead("data.bin"))
            //{
            //    using (var ds = new DeflateStream(stream, CompressionMode.Decompress))
            //    {
            //        for (int i = 0; i < stream.Length; i++)
            //        {
            //            Console.WriteLine(ds.ReadByte());
            //        }
            //    }
            //}

            #endregion
            #region NugtPackages
            //var comments = new List<FBComment>
            //{
            //     new FBComment
            //     {
            //         Owner = "Omar" ,
            //         Comment = ".Net is The Powerfull Web Framework " ,
            //          CreatedAt = new DateTime(2021,01,01,10,30,00)
            //     },
            //     new FBComment
            //     {
            //         Owner = "Salem" ,
            //         Comment = ".Net is The Powerfull Web Framework " ,
            //         CreatedAt = new DateTime(2022,01,01,10,30,00)
            //     },new FBComment
            //     {
            //         Owner = "Abdalla" ,
            //         Comment = ".Net is The Powerfull Web Framework " ,
            //         CreatedAt = new DateTime(2021,03,03,10,30,00)
            //     },new FBComment
            //     {
            //         Owner = "Amr" ,
            //         Comment = ".Net is The Powerfull Web Framework " ,
            //         CreatedAt = new DateTime(2021,01,20,10,30,00)
            //     }
            //};

            //foreach (var c in comments)
            //    Console.WriteLine(c);

            #endregion
            #region Thread
            ////var wallet = new Wallet("Omar", 100);
            ////wallet.RunRandomTransactions();
            ////Console.WriteLine("------------------------------------------------");
            ////Console.WriteLine($"{wallet}\n");

            ////wallet.RunRandomTransactions();
            ////Console.WriteLine("------------------------------------------------");
            ////Console.WriteLine($"{wallet}\n");

            //Console.WriteLine(Thread.CurrentThread);
            //Thread.CurrentThread.Name = "Main Thread";
            //var wallet = new Wallet("Omar" , 100);
            //Thread T1 = new Thread(wallet.RunRandomTransactions);
            //T1.Name = "T1"; // طول ما انا مناديتش  فانكشن البدء هيكون لسه متشتغلش
            //Console.WriteLine($"after declaration {T1.Name} state is {T1.ThreadState}");

            //T1.Start(); //  هنا اشتغل 
            //Console.WriteLine($"after Start() {T1.Name} state is {T1.ThreadState}");

            //T1.Join();// بيشغل الاول ويخلي التاني يوقف لغايه لما يخلص 
            //// * لو انا عايز النتيجه من الاول عشان استخدمها في التاني فا بعمل join()

            //Console.WriteLine($"after start {T1.Name} state is {T1.ThreadState}");

            //Thread T2 = new Thread(new ThreadStart(wallet.RunRandomTransactions));
            //T2.Name = "T2";
            //T2.Start();

            #endregion
            #region Task
            //Task<DateTime> task = Task.Run(()=> DateTime.Now);
            //Console.WriteLine(task.Result); // block thead until result is ready
            ////task.GetAwaiter().GetResult(); // نفس الاوت بوت للفوق
            #endregion
        #region stream
        static void Example01()
        {
            string path = @"D:\sample.txt";
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                Console.WriteLine($"Length {fs.Length}");
                Console.WriteLine($"CanRead {fs.CanRead}");
                Console.WriteLine($"CanWrite {fs.CanWrite}");
                Console.WriteLine($"CanSeek {fs.CanSeek}");
                Console.WriteLine($"CanTimeout {fs.CanTimeout}");
                Console.WriteLine($"Position {fs.Position}");

                for (byte i = 65; i < 123; i++)
                {
                    fs.WriteByte(i);
                }
            }
        }
        static void Example02()
        {
            string path = @"D:\sample.txt";
            using (var fs = new FileStream(path, FileMode.Open , FileAccess.ReadWrite))
            {
                byte[] data = new byte[fs.Length];
                int numBytesToRead = (int)fs.Length;
                int numBytesRead = 0;
                while(numBytesToRead > 0)
                {
                    int n = fs.Read(data, numBytesRead, numBytesToRead);
                    if (n == 0)
                        break;
                    numBytesToRead -= n;
                    numBytesRead += n;
                }
                foreach (var b in data)
                {
                    Console.WriteLine(b);
                }

                var newPath = @"D:\sample02.txt";
                using(var fsw = new FileStream(newPath , FileMode.OpenOrCreate , FileAccess.ReadWrite))
                {
                    fsw.Write(data ,0, data.Length);
                }
            }

        }
        static void Example03()
        {
            var path = @"D:\sample03.txt";
            using(var sw = new StreamWriter(path))
            {
                sw.WriteLine("This");
                sw.WriteLine("is");
                sw.WriteLine("C#");
            }

            using (var sr = new StreamReader(path))
            {
                while(sr.Peek() > 0)
                {
                    Console.WriteLine((char) sr.Read());
                }
            }

            using (var sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) is not null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        static void Example04()
        {
            string path = @"D:\sample04.txt";
            string[] Lines =
            {
                "Omar",
                "salem"
            };
            File.WriteAllLines(path, Lines);
        }
        #endregion
        #region Pintstack
        static void PrintStack(string name , Stack <Command> commands)
        {
            Console.WriteLine($"{name} History");
            Console.BackgroundColor = name.ToLower() == "back" ? ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;
            foreach(var url in commands)
            {
                Console.WriteLine($"\t {url}");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        #endregion
        #region prinList
        //static void prinList (List <Country> countries)
        //{
        //    foreach (var c in countries)
        //    {
        //        Console.WriteLine(c);
        //    }

        //    Console.WriteLine($"count {countries.Count}");
        //    Console.WriteLine($"capacity {countries.Capacity}");
        //}
        #endregion
       /* private static void Stock_StockChanged(Stock stock, decimal OldPrice)
        {
            if (stock.Price > OldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (stock.Price < OldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine($"{stock.Name} {stock.Price}");
        }*/
    }
    #region Thread
    class Wallet
    {
        public string Name { get; private set; }
        public int Bitcoins { get; private set; }

        public Wallet(string name, int bitcoins)
        {
            Name = name;
            Bitcoins = bitcoins;
        }

        public void Debit(int amount)
        {
            Thread.Sleep(1000);
            Bitcoins -= amount;
            Console.WriteLine($"[Thread :{Thread.CurrentThread.ManagedThreadId} - {Thread.CurrentThread.Name}" +
                                 $", Processor Id: {Thread.GetCurrentProcessorId()} ] -{amount}");
        }
        public void Credit(int amount)
        {
            Thread.Sleep(1000);
            Bitcoins += amount;
            Console.WriteLine($"[Thread :{Thread.CurrentThread.ManagedThreadId}  - {Thread.CurrentThread.Name}" +
                                 $", Processor Id: {Thread.GetCurrentProcessorId()} ] +{amount}");
        }

        public void RunRandomTransactions()
        {
            int[] amounts = { 10, 20, 30, -10, -20, 30, 4, 50, -30 };
            foreach (var amount in amounts)
            {
                var absVal = Math.Abs(amount);
                if (amount < 0)
                    Debit(absVal);
                else
                    Credit(absVal);
               
            }
        }
        public override string ToString()
        {
            return $"[{Name} -> {Bitcoins} Bitcoins]";
        }
    }
    #endregion
    #region NugtPackages
    class FBComment
    {
        public string Owner { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public override string ToString()
        {
            return 
                $"\"{Owner}\" Says :\n " +
                $"\"{Comment}\"" +
                $"\n\t\t\t\t {CreatedAt.Humanize()}";
            // Humanize is a packege to make like date {one year ago} 
        }
    }
    #endregion
    #region Dispose 
    class CurrencyService : IDisposable // step 1  deceler inheritance
    {

        private readonly HttpClient _HttpClient; // unMange Code 
        private bool _disposeFlag = false;  
        public CurrencyService()
        {
            _HttpClient = new HttpClient();
        }

        // if user forget use using 
        // dispose unmanaged only becuse managed is dispose 
        ~CurrencyService()
        {
            Dispose(false);
        }
         
        // disposing == true (disposing maneged and unmangend)
        // disposing == false (unmangend and large feilds)
        
        protected  virtual void Dispose(bool disposing) //step3
        {
            if (_disposeFlag)
                return;
            //dispose logic
            if(disposing)
            {
                // dispse maneged resources
                _HttpClient.Dispose();
            }
            _disposeFlag = true;
        }
        public void Dispose() // step 2 deceler a method
        {
            Dispose(true);
            GC.SuppressFinalize(this); // if use dispose dont call distractor
        }

        public string GetCurrencies()
        {
            string url = "http://coinbase.com/api/v2/currencies";
            var res = _HttpClient.GetStringAsync(url).Result;
            return res;
        }
    }
    #endregion
    #region Stack and Queue
    class Command
    {
        private readonly DateTime _createdAt;
        private readonly string _url;

        public Command( string url)
        {
            _createdAt = DateTime.Now;
            _url = url;
        }
        public override string ToString()
        {
            return $"[ {this._createdAt.ToString("yyyy-MM-dd hh:mm")}] {this._url}";
        }
    }

    //---------------------------------------------------------------------------------------------
    class PrintJop
    {
        private readonly string _file;
        private readonly int _copies;

        public PrintJop(string file, int copies)
        {
            _file = file;
            _copies = copies;
        }

        public override string ToString()
        {
            return $"{_file} X # {_copies} Copies";
        }
    }
    #endregion
    #region List and Dictionaries
    class Country
    {
        public string ISOCode { get; set; }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                int Hash = 2;
                Hash *= 3 + ISOCode.GetHashCode(); 
                Hash *= 3 + Name.GetHashCode();
                return Hash;
            }
        }

        public override bool Equals(object obj)
        {
            var country = obj as Country;
            if (country is null)
                return false;
            return this.Name.Equals(country.Name, StringComparison.OrdinalIgnoreCase)
            && this.ISOCode.Equals(country.ISOCode, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"{Name} ({ISOCode})";
        }
    }
    #endregion
    #region Extentions

    static class PizzaExtentions
    {

        public static Pizza AddDough(this Pizza value , string type)
        {
            value.Content += $"\n {type} Dough X $4.00";
            value.TotalPrice += 4m;
            return value;
        }
        public static Pizza AddSauce(this Pizza value)
        {
            value.Content += $"\n Tomato Sauce";
            value.TotalPrice += 2m;
            return value;
        }

        public static Pizza AddCheeze(this Pizza value, bool extra)
        {
            value.Content += $"\n {(extra ? "Extra" : "Regular")} cheeze source X ${(extra ? "6.00" : "4.00")}";
            value.TotalPrice += extra ? 6m : 4m;
            return value;
        }

        public static Pizza AddToppings(this Pizza value , string type, decimal price)
        {
            value.Content += $"\n {type} X ${price.ToString("#.##")}";
            value.TotalPrice += price;
            return value;
        }
    }
    class Pizza
    {
        public string Content { get; set; }
        public decimal TotalPrice { get; set; }
        public override string ToString()
        {
            return $"{Content}\n --------------------------- \n Total Price ${TotalPrice.ToString("#.##")}";
        }
    }
    #endregion
    #region XML Documentation
    class Genaretor
    {
        private static int LastIdSequance { get; set; } = 1; 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hireTime"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static string GenereteId(string name,  DateTime? hireTime) 
        {
            // NN YY MM DD 01
            if(name is null)
                throw new InvalidOperationException($"{nameof (name) } can not to be null");
            if(hireTime is null)
                hireTime = DateTime.Now;
            else
            {
                if (hireTime.Value < DateTime.Now.Date)
                    throw new InvalidOperationException($"{nameof(hireTime)} can not to be in past");
            }
            var YY = hireTime.Value.ToString("YY");
            var MM = hireTime.Value.ToString("MM");
            var DD = hireTime.Value.ToString("DD");


            var Code = $"{name.ToUpper()[0]} {YY} / {MM} / {DD} {(LastIdSequance++).ToString().PadLeft(2,'0')}";

            return Code;
        }
        public static string GenerateRandomPassword(int Lenght)
        {
            const string ValidCode = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ012356789";
            var res = "";
            Random rnd = new Random();
            while(Lenght-- > 0)
            {
                res += ValidCode[rnd.Next(ValidCode.Length)];
            }
            return res;
        }
    }
    #endregion
    #region IComparable
    class Tempreture : IComparable
    {
        private int _value;

        public Tempreture(int value)
        {
            _value = value;
        }
        public int Value => _value;

        public int CompareTo(object obj)
        {
            if(obj is null)
                return 1;
            var tmp = obj as Tempreture;
            if (tmp is null)
                throw new ArgumentException("Object is not tempreture object");
            return this._value.CompareTo(tmp._value);
        }
    }
    #endregion
    #region Enumerators
    class FiveIntegers
    {
        int[] _values;
        public FiveIntegers(int n1 , int n2, int n3 , int n4 , int n5)
        {
            _values = new [] { n1, n2 , n3 , n4 , n5};
        }
        public IEnumerator GetEnumerator() => new Enumerator(this);
        //في كلمه yield بتعلم كل الي تكنب تحت 
        /*
         public IEnumerator GetEnumerator()
         {
            foreach(var i in _values)
            {
                yield return i;
            }
         }
         
         */
        class Enumerator : IEnumerator
        {
            int currentIndex = -1;
            FiveIntegers _integers;
            public Enumerator(FiveIntegers integers)
            {
                _integers = integers;
            }
            public object Current
            {
                get
                {
                    if (currentIndex == -1) throw new InvalidOperationException("Eumeration not statred");
                    if (currentIndex == _integers._values.Length ) throw new InvalidOperationException("Eumeration has endd");
                    return _integers._values[currentIndex];
                }
            }
            public bool MoveNext()
            {
                if(currentIndex >= _integers._values.Length - 1)
                    return false;
                return ++currentIndex < _integers._values.Length;
            }

            public void Reset() => currentIndex = -1;
            
        }
    }
    #endregion
    #region Exceptions
    public class Delivery
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public Stutas DeliveryStutas { get; set; }

        public override string ToString()
        {
            return $"{{\n   Id: {Id},\n   Name: {Name}\n   Address: {Address}\n   Stutas: {DeliveryStutas} \n}}";

        }
    }
    public enum Stutas
    {
        UNKNOWN,
        PROCESSED,
        SHIPPED,
        INTRANSIT,
        DELIVERED
    }

    public class DilveryService
    {
        private readonly static Random random = new Random();
        public void start(Delivery delivery)
        {
            try
            {
                process(delivery);
                ship(delivery);
                transit(delivery);
                Deliver(delivery);
            }
            catch(AccidentException ex )
            {
                Console.WriteLine($"\nLocation at {ex.Location} : {ex.Message}");
                delivery.DeliveryStutas = Stutas.UNKNOWN;
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"\nDeliver Fails due to : {ex.Message}");
            //    delivery.DeliveryStutas = Stutas.UNKNOWN;
            //}
            finally
            {
                Console.WriteLine("END");
            }
        }

        private void process(Delivery delivery)
        {
            FakeIt("\nprocess");
            if (random.Next(1, 3) == 1)
            {
                throw new InvalidExpressionException("Unable to process the item");
            }

            delivery.DeliveryStutas = Stutas.PROCESSED;
        }
        private void ship(Delivery delivery)
        {
            FakeIt("\nship");
            if (random.Next(1, 3) == 1)
            {
                throw new InvalidExpressionException("Parcel is damged during the loading process");
            }
            delivery.DeliveryStutas = Stutas.SHIPPED;
        }
        private void transit(Delivery delivery)
        {
            FakeIt("\ntransit");
            if (random.Next(1, 3) == 1)
            {
                throw new AccidentException("street", "ACCIDENT!!!!!"); 
            }
            
            delivery.DeliveryStutas = Stutas.INTRANSIT;
        }
        private void Deliver(Delivery delivery)
        {
            FakeIt("\nDeliver");
            delivery.DeliveryStutas = Stutas.DELIVERED;
        }
        private void FakeIt(string s)
        {
            Console.Write(s);
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
        }
    }


    public class AccidentException :Exception
    {
        public string Location { get; set; }
        public AccidentException(string location , string Massage) : base(Massage)
        {
            Location = location;
        }
    }
    #endregion
    #region interface
    class Cashier
    {
        private Ipayment _payment;
        public Cashier(Ipayment payment)
        {
            _payment = payment;
        }

        public void CheckOut(decimal amount)
        {
            _payment.Pay(amount );
        }
    }
    interface Ipayment
    {
        void Pay(decimal amount ) {}
    }


    class Cash :Ipayment
    {
        public void Pay(decimal amount) { Console.WriteLine($"Cash Payment : ${Math.Round(amount, 2):N0} "); }
    }

    class Debit :Ipayment
    {
        public void Pay(decimal amount) { Console.WriteLine($"Debit Payment: ${Math.Round(amount, 2):N0} "); }
    }

    class Visa :Ipayment
    {
        public void Pay(decimal amount ) { Console.WriteLine($"Visa Payment: ${Math.Round(amount, 2):N0} "); }
    }

    class MasterCard :Ipayment
    {
        public void Pay(decimal amount ) { Console.WriteLine($"MasterCard Payment : ${Math.Round(amount, 2):N0} "); }
    }
    #endregion
    #region struct
    struct DigitalSize
    {
        private long bit;
        private const long bitsInBit = 1, bitsInByte = 8, bitsInKB = bitsInByte * 1024 , bitsInMB = bitsInKB * 1024 , bitsInGB = bitsInMB * 1024;
        public string Bit =>  $"{(bit / bitsInBit):N0}";
        public string Byte => $"{(bit / bitsInByte):N0}";
        public string KB =>   $"{(bit / bitsInKB):N0}";
        public string MB =>   $"{(bit / bitsInMB):N0}";
        public string GB =>   $"{(bit / bitsInGB):N0}";


        public DigitalSize(long intialValue)
        {
            this.bit = intialValue;
        }
    }
    #endregion
    #region Event
    public delegate void StockPriceChangeHandler(Stock stock, decimal OldPrice);
    public class Stock
    {
        private string name;
        private decimal price;

        public event StockPriceChangeHandler StockChanged; // data type of event = deleget name;

        public string Name=>this.name;
        public decimal Price 
        {
            get => this.price;
            set => this.price = value;
        }

        public Stock(string Stockname)
        {
            this.name = Stockname;
        }

        public void changeStockByPercent (decimal precent)
        {
            decimal oldPrice = this.price;
            this.price += Math.Round(this.price * precent,2);
            if(StockChanged != null)
            {
                StockChanged(this, oldPrice);
            }
        }
    }
    #endregion
    #region Multi Deleget
    public class RectnagleHelper
    {
        public void GetArea(decimal x, decimal y)
        {
            Console.WriteLine($"Area : {x*y}");
        }

        public void GetPerimeter(decimal x, decimal y)
        {
            Console.WriteLine($"Perimeter : {2 * (x+y)}");
        }
    }
    #endregion
    #region indexer
    public class IP
    {
        private int [] segments  = new int[4];

        //idexer
        public int this[int index]
        { 
            get
                { return segments[index]; }
            set 
                { segments[index] = value; }
        }

        public IP(string Adress)
        {
            string []segs = Adress.Split(".");
            for (int i = 0; i < segs.Length; i++)
            {
                segments[i] = Convert.ToInt32 (segs[i]);
            }

        }
        public IP(int segment1 , int segment2, int segment3, int segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;
        }

        public string Adress => string.Join(".", segments);

        private int[,] _mat = new int[,] { } ;
        public int  this[int row, int col]
        {
            get { return _mat[row, col]; }
            set { _mat[row, col] = value; } 
        }

        public IP(int[,] Mat )
        {
            _mat = Mat;
        }
    }
    #endregion
    #region proparties
    public class Dollar 
    {
        private decimal _amount;

        // get && set  
        public decimal Amount
        {
            get { return _amount; }
            set { _amount = ProcessValue(value); }
        }

        public Dollar(decimal amout)
        {
            this._amount = amout;
        }
        private decimal ProcessValue(decimal value) => value <= 0 ? 0 : value;

    }
    public class Date
    {                                               //1    2     3   4  5   6   7   8   9   10  11  12
        private static readonly int[] dayInMonth365 = {31 ,28 , 31, 30 ,31 ,30, 31, 31 ,30, 31 ,30 ,31};
        private static readonly int[] dayInMonth366 = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // readonly can be change inside constructor
        private  readonly int day ;
        private  readonly int month ;
        private  readonly int year ;

        public Date(int day , int month , int year )
        {
            if(year >= 1  && year <= 9999 && month >= 1 && month <= 12)
            {
                bool isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
                int[]days = isLeap ? dayInMonth366 : dayInMonth365;
                if(day >= 1 && day <= days[month-1])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }
                else
                {
                    this.day = 1;
                    this.month = 1;
                    this.year = 1;
                }
            }
            else
            {
                this.day = 1;
                this.month = 1;
                this.year = 1;
            }

        }


        // overloading 
        public Date (int year ) :this (1,1 ,year)
        { }
        public Date(int month , int year) : this(1, month, year)
        { }

        public string GetDate ()
        {
            return $"{day.ToString().PadLeft(2, '0')} / {month.ToString().PadLeft(2, '0')} / {year.ToString().PadLeft(4, '0')}";
        }
    }
    #endregion
    /*public class Report
    {
        public delegate bool SalesProcess(Employee e); // object that point to method to change at run time 
        public void ProcessEmployee(Employee[] emps, string title, SalesProcess isProcess)
        {
            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var emp in emps)
            {
                if (isProcess(emp))
                {
                    Console.WriteLine($"Id : {emp.Id} | Name : {emp.Name} | Totle Salary : ${emp.TotelSalary}");
                }
            }
            Console.Write("\n\n");

        }
   }*/
}
