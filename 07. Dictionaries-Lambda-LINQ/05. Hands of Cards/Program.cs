using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hands_of_Cards
{
    class Program
    {
        static int CountOfPoints(string cardP, char cardT)
        {
            var cardPower = new Dictionary<string, int>()
            {
                { "2", 2 }, { "3", 3 }, { "4", 4 }, { "5", 5 },
                { "6", 6 }, { "7", 7 }, { "8", 8 }, { "9", 9 }, { "10", 10 },
                { "J", 11 }, { "Q", 12 }, { "K", 13 }, { "A", 14 }
            };

            var cardType = new Dictionary<char, int>()
            {
                { 'S', 4 }, { 'H', 3 }, { 'D', 2 }, { 'C', 1 }
            };

            int points = 0;
            points += cardPower[cardP] * cardType[cardT];
            return points;
        }

        static void Main()
        {
           var players = new Dictionary<string, List<string>>();
            string inputString = null;

            while (inputString != "JOKER")
            {
                List<string> inputLine = Console.ReadLine()
                    .Split(':', ',', ' ')
                    .ToList();

                inputString = inputLine[0];
                string playerName = inputLine[0];
                inputLine.RemoveAt(0);
                inputLine.RemoveAt(0);
                inputLine.Sort();

                if (players.ContainsKey(playerName) == false)
                {
                    players.Add(playerName, inputLine);
                }
                else
                {
                    for (int i = 0; i < inputLine.Count; i++)
                    {
                    players[playerName].Add(inputLine[i]);
                    }
                }

                //Discarding duplicated card
                for (int i = 0; i < inputLine.Count - 1; i++)
                {
                    if (inputLine[i] == inputLine[i + 1])
                    {
                        inputLine.RemoveAt(i + 1);
                        i--;
                    }
                }

                ////Printing cards
                //foreach (var pair in players)
                //{
                //    Console.Write($"{pair.Key}: ");
                //    Console.WriteLine(String.Join(" ", pair.Value));
                //}

                //Counting points

                foreach (var pair in players)
                {
                    int sum = 0;
                    for (int i = 0; i < pair.Value.Count; i++)
                    {
                        List<string> list = pair.Value;
                        list.RemoveAt(0);
                        string card = list[i];
                        int length = card.Length;
                        char cardT = card[length - 1];
                        string cardP = card.Remove(length - 1);
                        sum = sum + cardType[cardT] * cardPower[cardP];
                    }
                    Console.WriteLine($"{pair.Key}: {sum}");
                }
            }
        }
    }
}