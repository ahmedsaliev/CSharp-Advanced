using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var numbers = new SortedDictionary<double, int>();
            foreach (var number in input)
            {
                if (!numbers.ContainsKey(number))
                {
                    //numbers.Add(number, 0);
                    numbers[number] = 0;

                }
                numbers[number]++;
            }
            foreach (var pair in numbers)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value} times");
            }
        }
    }
}