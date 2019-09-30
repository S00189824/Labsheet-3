using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
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

        private int engineSize;

        public int EngineSize
        {
            get { return this.engineSize; }
            set { this.engineSize = value; }
        }
    }

 
}
