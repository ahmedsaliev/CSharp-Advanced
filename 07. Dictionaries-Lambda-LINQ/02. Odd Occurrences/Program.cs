using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().ToLower().Split();
            var words = new Dictionary<string, int>();
            foreach (var word in input)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, 1);
                }
                else
                {
                    words[word]++;
                }
            }

            var oddCount = new List<string>();

            foreach (KeyValuePair<string, int> pair in words)
            {
                if (pair.Value % 2 != 0)
                {
                    oddCount.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", oddCount));
        }
    }
}
