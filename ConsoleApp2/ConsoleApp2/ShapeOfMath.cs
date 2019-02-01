using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ShapeOfMath
    {
        public static double GetArea(string Shape = "",
            double Length = 0,
            double Width = 0)
        {
            if (String.Equals("Rectangle", Shape, StringComparison.OrdinalIgnoreCase))
            {
                return Length * Width;
            }
            else if (String.Equals("Triangle", Shape, StringComparison.OrdinalIgnoreCase))
            {
                return Length * (Length / 2);
            }
            else if (String.Equals("Circle", Shape, StringComparison.OrdinalIgnoreCase))
            {
                return Math.PI * (Math.Pow(Length, 2));
            }
            else return -1;
        }
    }
}
