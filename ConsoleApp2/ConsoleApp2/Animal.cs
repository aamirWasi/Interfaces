using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Animal
    {
        public string Name;
        public string Sound;

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }
        public Animal(string name="No Name",
            string sound="No Sound")
        {
            Name = name;
            Sound = sound;
            numOfAnimals++;
        }
        public static int numOfAnimals { get; set; }
        public static int NumOfAnimals()
        {
            return numOfAnimals;
        }
    }
}
