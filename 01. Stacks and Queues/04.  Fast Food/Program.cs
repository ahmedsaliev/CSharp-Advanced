using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.__Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> ordersQueue = new Queue<int>(input);

            Console.WriteLine(input.Max());

            if (input.Sum() <= foodQuantity)
            {
                Console.WriteLine("Orders complete");
            }

            else
            {
                while (foodQuantity >= ordersQueue.Peek())
                {
                    foodQuantity -= ordersQueue.Peek();
                    ordersQueue.Dequeue();
                }

                Console.Write("Orders left: ");
                Console.WriteLine(String.Join(" ", ordersQueue.ToArray()));
            }
        }
    }
}