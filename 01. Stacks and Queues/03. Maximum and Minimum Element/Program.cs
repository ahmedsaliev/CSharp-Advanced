using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Stack<int> numbersStack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                int[] query = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                switch (query[0])
                {
                    case 1:
                        numbersStack.Push(query[1]);
                        break;
                    case 2:
                        if (numbersStack.Count > 0)
                        {
                            numbersStack.Pop();
                        }
                        break;
                    case 3:
                        if (numbersStack.Count > 0)
                        {
                            Console.WriteLine(numbersStack.ToArray().Max());
                        }
                        break;
                    case 4:
                        if (numbersStack.Count > 0)
                        {
                            Console.WriteLine(numbersStack.ToArray().Min());
                        }
                        break;
                }
            }

            if (numbersStack.Count > 0)
            {
                Console.WriteLine(String.Join(", ", numbersStack.ToArray()));
            }
        }
    }
}