using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cr1 = new CashRegister();

            Console.WriteLine("Adding a total of 2.70 to cash register 1");
            Console.WriteLine("Adding a total of 3.45 to cash register 1");
            Console.WriteLine("Adding a total of 1.43 to cash register 1");
            Console.WriteLine("Adding a total of 5.97 to cash register 1");
            Console.WriteLine("Adding a total of 12.52 to cash register 1");

            cr1.AddItem(2.70);
            cr1.AddItem(3.45);
            cr1.AddItem(1.43);
            cr1.AddItem(5.97);
            cr1.AddItem(12.52);

            CashRegister cr2 = new CashRegister();

            Console.WriteLine("Adding a total of 4.70 to cash register 2");
            Console.WriteLine("Adding a total of 7.45 to cash register 2");
            Console.WriteLine("Adding a total of 1.43 to cash register 2");
            Console.WriteLine("Adding a total of 3.97 to cash register 2");
            Console.WriteLine("Adding a total of 13.52 to cash register 2");

            cr2.AddItem(4.70);
            cr2.AddItem(7.45);
            cr2.AddItem(1.43);
            cr2.AddItem(3.97);
            cr2.AddItem(13.52);

            Console.WriteLine("Cash Register Cr1 Total >> {0}", cr1.total);
            Console.WriteLine("Cash Register Cr1 Number of items >> {0}", cr1.numberOfItems);
            Console.WriteLine("Cash Register Cr2 Total >> {0}", cr2.total);
            Console.WriteLine("Cash Register Cr2 Number of items >> {0}", cr2.numberOfItems);
        }
    }
}
