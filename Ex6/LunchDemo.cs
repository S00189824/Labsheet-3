using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class LunchDemo
    {
        public string Entree { get; set; }
        public string Side { get; set; }
        public string Drink { get; set; }

        public static void table(params LunchDemo[] lunches)
        {
            foreach (LunchDemo meal in lunches)
            {
                Console.WriteLine(meal.Entree);
                Console.WriteLine(meal.Side);
                Console.WriteLine(meal.Drink);
            }
        }

    }
}
