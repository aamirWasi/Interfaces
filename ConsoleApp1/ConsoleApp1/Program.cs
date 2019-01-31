using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 160, 4);
            if(buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine($"The {buick.Brand} can't driven");
            }
            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powButt = new PowerButton(TV);
            powButt.Execute();
            powButt.Undo();
        }
    }
}
