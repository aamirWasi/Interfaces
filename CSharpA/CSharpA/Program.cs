using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpA
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 165, 4);
            if(buick is Vehicle)
            {
                buick.Move();
            }
            else
            {
                Console.WriteLine($"The {buick.Brand} can't be Driven");
            }
            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powBtn = new PowerButton(TV);
            powBtn.Execute();
            powBtn.Undo();
        }
    }
}
