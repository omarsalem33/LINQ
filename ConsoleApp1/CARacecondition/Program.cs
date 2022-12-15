using System;
using System.Threading;

namespace CARacecondition
{
    class Program
    {
        static void Main(string[] args)
        {
            var w1 = new Wallet(1,"omar", 150);
            var w2 = new Wallet(2,"abdalla", 250);
            Console.WriteLine("\n Before Transaction...");
            Console.WriteLine("\n-------------------------");
            Console.Write(w1 + "\t"); Console.WriteLine(w2 +"\n") ;
            Console.WriteLine("After Transaction ...");
            Console.WriteLine("\n-------------------------");

            var transaction1 = new WalletTransfar(w1, w2, 50);
            var transaction2 = new WalletTransfar(w2, w1, 100);

            var t1 = new Thread(transaction1.Transfer);
            t1.Name = "T1";
            var t2 = new Thread(transaction2.Transfer);
            t2.Name = "T2";

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.Write(w1 + "\t"); Console.WriteLine(w2 + "\n");


        }
    }

    
    class Wallet
    {
        private readonly object bitcoinsLock = new object(); // refrance type
        public string Name { get; private set; }
        public int Bitcoins { get; private set; }
        public int Id { get; private set; }

        public Wallet(int id, string name, int bitcoins)
        {
            Name = name;
            Bitcoins = bitcoins;
            Id = id;
        }

        public void Debit(int amount)
        {
            lock(bitcoinsLock) // lock ---> refrance only
            {
                if (Bitcoins > amount)
                {
                    Thread.Sleep(1000);
                    Bitcoins -= amount;
                }
            }
           
        }
        public void Credit(int amount)
        {
            Thread.Sleep(1000);
            Bitcoins += amount;
            
        }

       
        public override string ToString()
        {
            return $"[{Name} -> {Bitcoins} Bitcoins]";
        }
    }


    class WalletTransfar
    {
        private Wallet to;
        private Wallet from;
        private int amounttransfar;

        public WalletTransfar(Wallet to, Wallet from, int amounttransfar)
        {
            this.to = to;
            this.from = from;
            this.amounttransfar = amounttransfar;
        }

        public void Transfer()
        {

            var lock1 = from.Id <to.Id ? from : to;
            var lock2 = from.Id < to.Id ? to : from;
            Console.WriteLine($"{Thread.CurrentThread.Name} Trying to lock .... {from}");
            Thread.Sleep(1000);
            lock (lock1)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} lock acquired .... {from}");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} Trying to lock .... {to}");
                lock (lock2)
                {
                    from.Debit(amounttransfar);
                    to.Credit(amounttransfar);
                }   
            }


        }
    }

}
