using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }
        public void Off()
        {
            Console.WriteLine("The TV is Off");
        }

        public void On()
        {
            Console.WriteLine("The TV is On");
        }
        public Television(int volume = 0)
        {
            Volume = volume;
        }

        public void VolumeDown()
        {
            if (Volume == 5) Volume--;
            Console.WriteLine("The TV Volume is at {0}",Volume);
        }

        public void VolumeUp()
        {
            if (Volume == 0) Volume++;
            Console.WriteLine("The TV Volume is at {0}", Volume);
        }
    }
}
