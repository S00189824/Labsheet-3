using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BankAccount acc1 = new BankAccount("1232565467", "Dave Smith", 2000);
            //Here i am creating two new bank account objects from a class.
            BankAccount acc2 = new BankAccount("123257960", "Mary Smith", 1000);

            Console.WriteLine("Add 500 to account 1");
            acc1.Deposit(500);

            Console.WriteLine("Withdraw 1000 from account 2");
            acc2.Withdrawal(1000);
        }
    }
}
