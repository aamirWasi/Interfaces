using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehicle : IDrivable
    {
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }

        //Constructor
        public Vehicle(string brand,
            double speed,
            int wheels)
        {
            Brand = brand;
            Speed = speed;
            Wheels = wheels;
        }

        public void Move()
        {
            Console.WriteLine($"The {Brand} Moves Forward at {Speed} MPH"); ;
        }

        public void Stop()
        {
            Console.WriteLine($"The {Brand} stops");
            Speed = 0;
        }
    }
}
