using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooMach_04._11._2022
{
    public class Bank_Account
    {
        private byte ID { get; set; }
        private decimal Balance { get; set; }
        public enum Acc_Type : byte
        {
            Сберегательный,
            Накопительный
        }
        private Acc_Type Type { get; set; }
        private static HashSet<byte> Last_Random_ID = new HashSet<byte>(0);

        public Bank_Account() { }
        public Bank_Account(byte iD, decimal balance, Acc_Type type)
        {
            ID = iD;
            Balance = balance;
            Type = type;
        }
        public void Print() => Console.WriteLine($"Id: {ID}\nBalace: {Balance}\nType: {Type}");
        public byte new_ID()
        {
            Random r = new Random();
            ID = (byte)r.Next(0, 255);
            if (!Last_Random_ID.Contains(ID))
            {
                ID++;
            }
            return ID;
        }
        public void Add(decimal cash)
        {
            Balance += cash;
            Console.WriteLine($"Done! Balance: {Balance}");
        }
        public void Lower(decimal cash)
        {
            if (Balance > 0)
            {
                if (Balance - cash > 0)
                {
                    Balance -= cash;
                    Console.WriteLine($"Done! Balance: {Balance}");
                }
                else
                {
                    Console.WriteLine($"Not enougth money! Balance: {Balance}");
                }
            }
            else
            {
                Console.WriteLine("Something is wrong!");
            }
        }
        public void Transition(Bank_Account acc1, decimal perevod)
        {
            if (acc1.Balance > perevod)
            {
                acc1.Balance -= perevod;
                Balance += perevod;
            }
            else
            {
                Console.WriteLine("Not enought money");
            }
        }

    }
    internal class Program
    {
        static void Task83(string t)
        {
            if (Directory.GetFiles("C:\\Users\\илья\\source\\repos\\HW\\Tumakov8\\files").Contains(t))
            {
                FileInfo f1 = new FileInfo("file1.txt");
                f1.CopyTo(t);
            }
            else
            {
                Environment.Exit(0);
            }
        }
        static string Task82(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i > -1; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            // task 8.1
            Bank_Account acc1 = new Bank_Account(123, 3000, Bank_Account.Acc_Type.Сберегательный);
            Bank_Account acc2 = new Bank_Account(125, 1000, Bank_Account.Acc_Type.Накопительный);
            acc2.Transition(acc1, 1000);
            acc1.Print();
            acc2.Print();

            // task 8.2
            Console.WriteLine(Task82("Hello World"));

            // task 8.3
            Console.WriteLine("Enter a file name");
            string f1 = Console.ReadLine();
            Task83(f1);
            Console.ReadKey();
        }
    }
}
