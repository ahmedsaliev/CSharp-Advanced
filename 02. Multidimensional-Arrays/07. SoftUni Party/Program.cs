using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guestsList = new HashSet<string>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine != "PARTY")
                {
                    guestsList.Add(inputLine);
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine != "END")
                {
                    guestsList.Remove(inputLine);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(guestsList.Count);

            foreach (var guest in guestsList)
            {
                if (Char.IsNumber(guest[0]))
                {
                    Console.WriteLine(guest);
                }
            }

            foreach (var guest in guestsList)
            {
                if (!Char.IsNumber(guest[0]))
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}