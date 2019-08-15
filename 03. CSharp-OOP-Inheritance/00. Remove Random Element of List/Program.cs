using System;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            RandomList randomList = new RandomList();

            randomList.Add("Ivan");
            randomList.Add("Test");
            randomList.Add("Pesho");

            Console.WriteLine(randomList.RemoveRandom());
        }
    }
}