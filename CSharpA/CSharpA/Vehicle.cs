using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpA
{
    class Vehicle : IDrivable
    {
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }

        public Vehicle(string brand="No Brand",
            double speed = 0,
            int wheel = 0)
        {
            Brand = brand;
            Speed = speed;
            Wheels = wheel;
        }

        public void Move()
        {
            Console.WriteLine($"The {Brand} moves forward to at {Speed} with {Wheels} Wheels");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Brand} stops");
            Speed = 0;
        }
    }
}
