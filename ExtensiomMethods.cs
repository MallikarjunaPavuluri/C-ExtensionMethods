using System;
namespace BankExtension
{
   public class BankData
    {
        private double balance;
        private String id;
        private String panno;
        private String name;
        public BankData(string id, string panno, string name)
        {
            this.id = id;
            this.panno = panno;
            this.name = name;
            balance = 0;
        }
        public double Balance
        {
            set;
            get;
        } 
        public void Display()
        {
            Console.WriteLine($"ID-{id}");
            Console.WriteLine($"Name-{name}");
            Console.WriteLine($"Balance-{balance}");
            Console.WriteLine($"PanNo-{panno}");
        }

    }
    static class BankOperation
    {
       
        public static bool Deposit(this BankData d,double amount)
        {
            if(amount>0)
            {
                d.Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool WithDraw(this BankData d,double amount)
        {
            if(amount>0)
            {
                d.Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    } 
    public class Program
    {

        public static void Main(String[] args)
        {
            BankData c1 = new BankData("8008471623", "AIRCOMMONPANNO", "Mallikarjuna");
            var d = c1.Deposit(10000);
            if(d==true)
            {
                Console.WriteLine("Amount Deposited Success");
            }
            else
            {
                Console.WriteLine("Amount Deposited Fail");
            }
            c1.Display();
            var w=c1.WithDraw(1000);
            if (w == true)
            {
                Console.WriteLine("Amount withdraw Success");
            }
            else
            {
                Console.WriteLine("Amount withdraw Fail");
            } 
            c1.Display();


        }
    }
}
