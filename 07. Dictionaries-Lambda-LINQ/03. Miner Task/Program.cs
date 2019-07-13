using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Miner_Task
{
    class Program
    {
        static void Main()
        {
            string inputString = null;
            var inputText = new List<string>();

            while (inputString != "stop")
            {
                inputString = Console.ReadLine();
                inputText.Add(inputString);
            }

            var mineResources = new Dictionary<string, int>();

            for (int i = 0; i < inputText.Count - 1; i = i + 2)
            {
                string mineToAdd = inputText[i];
                int quantityToAdd = int.Parse(inputText[i + 1]);
                if (mineResources.ContainsKey(mineToAdd))
                {
                    mineResources[mineToAdd] += quantityToAdd;
                }
                else
                {
                mineResources.Add(mineToAdd, quantityToAdd);
                }
            }

            foreach (var pair in mineResources)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}