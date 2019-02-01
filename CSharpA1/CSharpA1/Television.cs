using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpA1
{
    class Television : IElectronicDevice
    {
        public string Name { get; set; }
        public int Volume { get; set; }
        public Television(string name="No Name",
            int vol1 = 0)
        {
            Name = name;
            Volume = vol1;
        }
        public void Off()
        {
            Console.WriteLine("The TV is Off");
        }

        public void On()
        {
            Console.WriteLine($"The {Name} TV is On & Volume is at {Volume}");
            VolumeUp();
        }

        public void VolumeDown()
        {
            if (Volume > 3) Volume--;
            Console.WriteLine($"The TV's Volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume < 0) Volume++;
            Console.WriteLine($"The TV's Volumn is at {Volume}");
        }
    }
}
