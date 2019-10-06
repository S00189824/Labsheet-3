using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class CashRegister
    {
        public static double AllCRS { get; set; }
        public static int TotalitemsAllcrs { get; set; }

        public int numberOfItems { get; set; }
        public double total { get; private set; }

        public void AddItem(double itemprice)
        {
            total += itemprice;
            numberOfItems++;

            TotalitemsAllcrs++;
            AllCRS += itemprice;
        }
    }
}
