using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int addedSum = AddTwoInt(7,13);
            Console.WriteLine($"Sum = {addedSum}");
        }

        static int AddTwoInt(int x, int y)
        {
            return x+y;
        }
    }
}
