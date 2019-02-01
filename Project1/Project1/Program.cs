using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle()
            {
                Name="Rectangle",
                Length = 20,
                Width = 10,
            };
            Rectangle rect2 = new Rectangle("Rectangle",
                200,
                50);
            rect2 = rect1;
            //rect1.Length = 2;
            Console.WriteLine("Length of rect1 is {0}",
                rect1.Length);
            Console.WriteLine("Length of rect2 is {0}",
                rect2.Length);
            Triangle triA = new Triangle("Triangle",5);
            Console.WriteLine($"Area of {triA.Name} is {triA.Area():f2}");
            Console.WriteLine($"Area of {rect1.Name} is {rect1.Area():f2}");


        }
        struct Rectangle
        {
            public string Name;
            public double Length;
            public double Width;
            public Rectangle(string name,
                double length,
                double width)
            {
                Name = name;
                Length = length;
                Width = width;
            }
            public double Area()
            {
                return Length * Width;
            }
        }
        //Triangle
        struct Triangle
        {
            public string Name;
            public double Radius;
            public Triangle(string name,
                double radius)
            {
                Name = name;
                Radius = radius;
            }
            public double Area()
            {
                return Math.PI*(Math.Pow(Radius,2));
            }
        }
    }
}
