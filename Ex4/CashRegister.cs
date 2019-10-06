using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class CashRegister
    {
        public int numberOfItems { get; set; }
        public double total { get; private set; }

        public void AddItem(double itemprice)
        {
            total += itemprice;
            numberOfItems++;
        }
    }
}
