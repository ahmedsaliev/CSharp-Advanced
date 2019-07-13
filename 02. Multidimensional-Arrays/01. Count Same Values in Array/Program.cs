using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> occurrences = new Dictionary<double, int> ();

            foreach (var number in inputArr)
            {
                if (!occurrences.ContainsKey(number))
                {
                    occurrences.Add(number, 0);
                }

                occurrences[number]++;
            }

            foreach (var kvp in occurrences)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}