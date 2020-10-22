using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int addedSum = AddTwoNumbers(7,13);
            Console.WriteLine($"Sum = {addedSum}");
            double addedDouble = AddTwoNumbers(7.5,13.8);

            List<Animal> animals = new List<Animal>();

            Animal animal = new Animal();
            Animal cat = new Cat();
            Animal llama = new Llama();

            animals.Add(animal);
            animals.Add(cat);
            animals.Add(llama);

            foreach (Animal a in animals)
            {
                a.MakeAnimalSounds();
            }


        }

        static int AddTwoNumbers(int x, int y)
        {
            return x+y;
        }

        static double AddTwoNumbers(double x, double y)
        {
            return x+y;
        } 
    }
}
