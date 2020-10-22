using System;

namespace Polymorphism
{
    class Animal
    {

        public virtual void MakeAnimalSounds()
        {
            Console.WriteLine("Making animal sounds.");

        }

    }

    class Cat : Animal
    {
        public override void MakeAnimalSounds()
        {
            Console.WriteLine("Meow");
        }
    }

    class Llama : Animal
    {
        public override void MakeAnimalSounds()
        {
            Console.WriteLine("Honk");
        }
    }

}
