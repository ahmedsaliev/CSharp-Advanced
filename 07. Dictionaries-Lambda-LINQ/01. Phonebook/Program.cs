using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Phonebook
{
    class Program
    {
        static void Main()
        {
            var phonebook = new Dictionary<string, string>();
            string command = string.Empty;

            while (command != "END")
            {
                var inputLine = Console.ReadLine()
                .Split(' ')
                .ToList();

                command = inputLine[0];

                switch (command)
                {

                    case "A":
                        string nameToAdd = inputLine[1];
                        string keyToAdd = inputLine[2];
                        //if (phonebook.ContainsKey(nameToAdd))
                        //{
                        //    phonebook[nameToAdd] = keyToAdd;
                        //}
                        //else
                        //{
                        //phonebook.Add(nameToAdd, keyToAdd);
                        //}
                        if (phonebook.ContainsKey(nameToAdd) == false)
                        {
                            phonebook.Add(nameToAdd, "");
                        }
                        phonebook[nameToAdd] = keyToAdd;
                        break;
                    case "S":
                        string nameToFind = inputLine[1];
                        if (phonebook.ContainsKey(nameToFind))
                        {
                            Console.WriteLine($"{nameToFind} -> {phonebook[nameToFind]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {nameToFind} does not exist.");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}