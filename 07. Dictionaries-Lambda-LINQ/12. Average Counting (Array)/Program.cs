using System;
using System.Linq;
using System.Collections.Generic;

namespace _12._Average_Counting
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int[]> values = new Dictionary<string, int[]>();

            values.Add("Ahmed Saliev", new int[3]);
            values["Ahmed Saliev"][0] = 6;
            values["Ahmed Saliev"][1] = 4;
            values["Ahmed Saliev"][2] = 5;

            values.Add("Fatma Ahmedova", new int[4]);
            values["Fatma Ahmedova"][0] = 2;
            values["Fatma Ahmedova"][1] = 4;
            values["Fatma Ahmedova"][2] = 3;
            values["Fatma Ahmedova"][3] = 6;

            foreach (var name in values)
            {
                Console.WriteLine($"{name.Key}::");
                Console.WriteLine(string.Join(", ", name.Value));
                Console.WriteLine("{0:f2}", name.Value.Average());
            }

            Console.WriteLine(new string('–', 35));
        }
    }
}
