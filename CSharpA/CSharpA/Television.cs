using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpA
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
            Console.WriteLine("The TV is Onn");
        }

        public void VolumeDown()
        {
            if (Volume != 3) Volume--;
            Console.WriteLine("The TV's Volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume <= 5) Volume++;
            Console.WriteLine("The TV's Volume is at {Volume}");
        }
    }
}
