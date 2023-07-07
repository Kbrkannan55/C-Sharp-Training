using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace basicprgm1
{
    internal class Animal : Sound, AnimalType
    {
        private string AnimalName;
        private int eyes, mouth, legs, tail;

        public string AnimalName1 { get => AnimalName; set => AnimalName = value; }
        public int Eyes { get => eyes; set => eyes = value; }
        public int Mouth { get => mouth; set => mouth = value; }
        public int Legs { get => legs; set => legs = value; }
        public int Tail { get => tail; set => tail = value; }

        public Animal(string animalName, int eyes, int mouth, int legs, int tail)
        {
            this.AnimalName = animalName;
            this.Eyes = eyes;
            this.Mouth = mouth;
            this.Legs = legs;
            this.Tail = tail;

        }

        public void MakeSound(string name)
        {
            if(name == "dog")
            {
                Console.WriteLine("Bow Bow");
            }
            else if(name=="cat")
            {
                Console.WriteLine("Meow Meow");
            }
            else 
            {
                Console.WriteLine();
            }
        }

        public void Type(string name)
        {
            if (name == "dog")
            {
                Console.WriteLine("Carnivore");
            }
            else if (name == "cow")
            {
                Console.WriteLine("Herbivore");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
