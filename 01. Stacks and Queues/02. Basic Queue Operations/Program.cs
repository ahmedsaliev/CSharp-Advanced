using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputFirst = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int N = inputFirst[0]; //Numbers to enqueue;
            int S = inputFirst[1]; //Numbers to dequeue;
            int X = inputFirst[2]; //Number to look for;

            int[] inputSecond = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbersQueue = new Queue<int>(inputSecond);

            for (int i = 0; i < S; i++)
            {
                numbersQueue.Dequeue();
            }

            if (numbersQueue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbersQueue.Count > 0)
                {
                    var min = numbersQueue.ToArray().Min();
                    Console.WriteLine(min);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}