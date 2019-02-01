using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpA1
{
    class vehicle : IDrivable
    {
        public String Brand { get; set; }
        public vehicle(string brand="No Brand",
            int wheel=0,
            double speed = 0)
        {
            Brand = brand;
            Wheels = wheel;
            Speed = speed;
        }
        public int Wheels { get; set; }
        public double Speed { get; set; }

        public void Move()
        {
            Console.WriteLine($"The {Brand} is moving with {Speed} MPH Speed within {Wheels} Wheels");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Brand} is stoping.");
        }
    }
}
