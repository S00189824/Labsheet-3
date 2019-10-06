using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            TheSchool Sch = new TheSchool();
            
            
            for(int i = 0;i<= 4;i++)
            {
                Console.WriteLine($"Enter School Name ");
                Sch.SchoolName = Console.ReadLine();
                Console.WriteLine($"Enter Enrollment ");
                Sch.NumberOfEnrollment = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
