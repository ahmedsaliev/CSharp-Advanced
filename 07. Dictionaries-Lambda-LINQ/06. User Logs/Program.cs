using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._User_Logs
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            if (command == "end") return;
            var users = new SortedDictionary<string, SortedDictionary<string, int>>();

            while (command != "end")
            {
                var splittedText = command.Split().ToArray();
                string IP = splittedText[0].Remove(0, 3);
                string user = splittedText[2].Remove(0, 5);

                if (users.ContainsKey(user) == false)
                {
                    users.Add(user, new SortedDictionary<string, int>());
                }

                if (users[user].ContainsKey(IP) == false)
                {
                    users[user].Add(IP, 0);
                }

                users[user][IP]++;

                command = Console.ReadLine();
            }


            foreach (var pair1 in users)
            {
                Console.WriteLine($"{pair1.Key}: ");
                int counter = pair1.Value.Count;
                foreach (var pair2 in pair1.Value)
                {
                    if (counter > 1)
                    {
                        Console.Write($"{pair2.Key} => {pair2.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{pair2.Key} => {pair2.Value}.");
                    }
                    counter--;
                }
            }
        }
    }
}
