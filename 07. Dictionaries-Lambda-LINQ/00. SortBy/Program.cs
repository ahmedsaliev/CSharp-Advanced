using System;
using System.Collections.Generic;
using System.Linq;

namespace _00._Excersice
{
    class Program
    {
        static void Main()
        {
            var phonebook = new SortedDictionary<string, List<int>>();

            phonebook.Add("Pesho", new List<int>());
            phonebook["Pesho"].Add(12);
            phonebook["Pesho"].Add(8);

            phonebook.Add("Maya", new List<int>());
            phonebook["Maya"].Add(78);
            phonebook.Add("Ahmed", new List<int>());
            phonebook["Ahmed"].Add(-15);


            foreach (var pair in phonebook)
            {
                pair.Value.Sort();
            }

            foreach (var name in phonebook)
            {
                Console.Write($"{name.Key}: ");
                Console.WriteLine(string.Join(", ", name.Value));
            }
        }
    }
}