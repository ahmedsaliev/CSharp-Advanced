using System;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            var randomList = new RandomList<string>
            {
                "Ivan",
                "Test",
                "Pesho"
            };

            Console.WriteLine(randomList.RemoveRandom());
        }
    }
}
