using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.__Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> clothesStack = new Stack<int>(input);
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int sum = 0;

            if (capacity >= clothesStack.ToArray().Sum())
            {
                Console.WriteLine(1);
                return;
            }

            while (clothesStack.Any())
            {
                sum += clothesStack.Peek();

                if (sum < capacity)
                {
                    clothesStack.Pop();
                }
                else if (sum == capacity)
                {
                    racks++;
                    clothesStack.Pop();
                    sum = 0;
                }
                else
                {
                    racks++;
                    sum = clothesStack.Pop();
                }
            }
            Console.WriteLine(racks);
        }
    }
}