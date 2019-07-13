using System;
using System.Collections.Generic;
using System.Linq;

namespace _00._OrderByMethods
{
    class Program
    {
        static void Main()
        {
            var listOfNumbers = new List<int>() { 10, 20, 5, 99 };

            var ordered = listOfNumbers.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", listOfNumbers));

            ordered = listOfNumbers.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(", ", listOfNumbers));

            int[] arr1 = { 1, 3, 7, 0 };
            Console.WriteLine(string.Join(", ", arr1));
            int[] arr2 = { 8, 8, 8 };

            Console.WriteLine(string.Join(", ", arr2));
            Console.WriteLine(string.Join(", ", arr1));

        }
    }
}
