using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Hands_Of_Cards__02_
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

        static Dictionary<string, List<string>> DrawingCards(Dictionary<string, List<string>> players)
        {
            string inputString = null;
            string[] text = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (text[0] == "JOKER")
            {
                return null;
            }

            while (inputString != "JOKER")
            {

                List<string> inputLine = text[1]
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string name = text[0];

                if (players.ContainsKey(name) == false && name != "JOKER")
                {
                    players.Add(name, inputLine);
                }
                else
                {
                    for (int i = 0; i < inputLine.Count; i++)
                    {
                        players[name].Add(inputLine[i]);
                    }
                }
                text = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
                inputString = text[0];
            }

            return players;
        }

        static Dictionary<string, List<string>> DiscardDuplicatedCards(Dictionary<string, List<string>> players)
        {
            foreach (var pair in players)
            {
                pair.Value.Sort();
                for (int i = 0; i < pair.Value.Count - 1; i++)
                {
                    if (pair.Value[i] == pair.Value[i + 1])
                    {
                        pair.Value.RemoveAt(i + 1);
                        i--;
                    }
                }
            }
            return players;
        }

        static void TotalPoints(Dictionary<string, List<string>> players)
        {
            foreach (var pair in players)
            {
                int sum = 0;
                for (int i = 0; i < pair.Value.Count; i++)
                {
                    string card = pair.Value[i];
                    int cardLength = pair.Value[i].Length;
                    char cardT = card[cardLength - 1];
                    string cardP = card.Remove(cardLength - 1);
                    sum += CountOfPoints(cardP, cardT);
                }

                Console.WriteLine($"{pair.Key}: {sum}");
            }
        }

        static void Main()
        {
            var players = new Dictionary<string, List<string>>();
            DrawingCards(players);
            DiscardDuplicatedCards(players);
            TotalPoints(players);
        }
    }
}