using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int? randnum = null;
            if (randnum == null)
            {
                Console.WriteLine("Random is Null");
            }
            if (!randnum.HasValue)
            {
                Console.WriteLine("Random is null");
            }
            Console.WriteLine("{0:f2} ",ShapeOfMath.GetArea("Circle",10,3));
            Animal Fox = new Animal("Fox", "Rawrrr");
            Fox.MakeSound();
            Animal whiskers = new Animal("whiskers", "Meow");
            Console.WriteLine($"Numbers of animal is {Animal.NumOfAnimals()}");
            
        }
    }
}
