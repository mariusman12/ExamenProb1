using System;


namespace SoundAnimalss
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = {

                new Dog(),
                new Tiger(),

                new Snake()
            };
            foreach (Animal animal in animals)
            {
                string animalName = animal.Name;
                string sound = animal.MakeSound();

                Console.WriteLine($"The {animalName} makes '{sound}'.");
            }


        }
    }
}