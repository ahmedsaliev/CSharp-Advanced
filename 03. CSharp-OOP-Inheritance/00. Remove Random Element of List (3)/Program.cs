using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            var randomList = new List<int>
            {
                1,
                5,
                6
            };

            Console.WriteLine(randomList.RemoveRandomElement());
        }
    }
}
