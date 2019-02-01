using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpA1
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetElectronic();
            PowerButton PowBtn = new PowerButton(TV);
            PowBtn.Execute();
            PowBtn.Undo();
            /*vehicle buick = new vehicle("Buick", 4, 190);
            if(buick is vehicle)
            {
                buick.Move();
                buick.Stop();
            }*/
        }
    }
}
