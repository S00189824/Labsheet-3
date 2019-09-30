using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new Car();

            Car c2 = new Car();

            c1.Make = "Ford";
            c1.Model = "Escort";
            c1.CurrentSpeed = 80;
            c1.EngineSize = 60;
            Console.WriteLine(c1.Make);
            Console.WriteLine(c1.Model);





        }
    }
}
