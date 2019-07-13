using System;
using System.Linq;
using System.Collections.Generic;

namespace _12._Average_Counting
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<int>> values = new Dictionary<string, List<int>>();

            values.Add("Ahmed Saliev", new List<int>());
            values["Ahmed Saliev"].Add(6);
            values["Ahmed Saliev"].Add(6);
            values["Ahmed Saliev"].Add(6);
            values["Ahmed Saliev"].Add(6);

            values.Add("Fatma Ahmedova", new List<int>());
            values["Fatma Ahmedova"].Add(6);
            values["Fatma Ahmedova"].Add(4);
            values["Fatma Ahmedova"].Add(5);
            values["Fatma Ahmedova"].Add(2);


            foreach (var name in values)
            {
                Console.WriteLine($"{name.Key}::");
                Console.WriteLine("{0:f2}", name.Value.Average());
            }
        }
    }
}
