﻿using System;
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
            c1.EngineSize = 1.6;


            c2.Make = "Ford";
            c2.Model = "Escort";
            c2.CurrentSpeed = 0;
            c2.EngineSize = 1.9;



            Console.WriteLine($"The {c1.Make} {c1.Model},engine size  {c1.EngineSize} is currently travelling at {c1.CurrentSpeed} km/h");
            Console.WriteLine(c1.Model);


            


        }
    }
}
