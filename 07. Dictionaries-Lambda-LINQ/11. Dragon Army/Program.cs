using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._Dragon_Army
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, SortedDictionary<string, int[]>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = input[0];
                string name = input[1];

                int damage = 45;
                int health = 250;
                int armor = 10;

                if (input[2] != "null") damage = int.Parse(input[2]);
                if (input[3] != "null") health = int.Parse(input[3]);
                if (input[4] != "null") armor = int.Parse(input[4]);

                if (dragons.ContainsKey(type) == false)
                {
                    dragons.Add(type, new SortedDictionary<string, int[]>());
                }

                if (dragons[type].ContainsKey(name) == false)
                {
                    dragons[type].Add(name, new int[3]);
                }

                dragons[type][name][0] = damage;
                dragons[type][name][1] = health;
                dragons[type][name][2] = armor;
            }

            foreach (var type in dragons)
            {
                double avDamage = type.Value.Select(x => x.Value[0]).Average();
                double avHealth = type.Value.Select(x => x.Value[1]).Average();
                double avArmor = type.Value.Select(x => x.Value[2]).Average();

                Console.WriteLine($"{type.Key}::({avDamage:F2}/{avHealth:F2}/{avArmor:F2})");
                foreach (var name in type.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }
            }
        }
    }
}