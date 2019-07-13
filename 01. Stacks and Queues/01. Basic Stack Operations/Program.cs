using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputFirst = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int N = inputFirst[0]; //Numbers of elements;
            int S = inputFirst[1]; //Numbers to pop;
            int X = inputFirst[2]; //Number to look for;

            int[] inputSecond = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbersStack = new Stack<int>(inputSecond);

            for (int i = 0; i < S; i++)
            {
                numbersStack.Pop();
            }

            if (numbersStack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbersStack.Count > 0)
                {
                    var min = numbersStack.ToArray().Min();
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