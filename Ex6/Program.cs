using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            LunchDemo L1 = new LunchDemo();

            L1.Entree = "hamburger";
            L1.Side = "Fries";
            L1.Drink = "Cola";

            LunchDemo L2 = new LunchDemo();

            L2.Entree = "hotdog";
            L2.Side = "chips";
            L2.Drink = "lemonade";

            LunchDemo L3 = new LunchDemo();

            L3.Entree = "pizza";
            L3.Side = "salad";
            L3.Drink = "iced tea";

            LunchDemo.table(L1, L2, L3);
        }
    }
}
