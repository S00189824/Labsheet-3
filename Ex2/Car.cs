using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Car
    {

        private string make;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        private string model;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        private int currentSpeed;

        public int CurrentSpeed
        {
            get { return this.currentSpeed; }
            set { this.currentSpeed = value; }
        }

        private double engineSize;

        public double EngineSize
        {
            get { return this.engineSize; }
            set { this.engineSize = value; }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Make : {Make}");
            Console.WriteLine($"Car Model : {Model}");
            Console.WriteLine($"Car Speed kph : {CurrentSpeed}");
            Console.WriteLine($"Engine Size : {engineSize}");
        }

        public override string ToString()
        {
            return string.Format($"Car Make : {Make} " +
                $"\nCar Model : {Model}" +
                $"\nCar Speed : {CurrentSpeed}" +
                $"\nCar Engine Size : {EngineSize}");
        }

        public void Accelerate()
        {
            CurrentSpeed += 10;
            Console.WriteLine($"Current speed is : {CurrentSpeed}");
        }
    }

 
}
