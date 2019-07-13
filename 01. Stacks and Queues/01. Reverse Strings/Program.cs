using System;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Stack<char> lettersStack = new Stack<char>(input);

            //Stack<char> lettersStack = new Stack<char>();

            //foreach (var ch in input)
            //{
            //    lettersStack.Push(ch);
            //}

            while (lettersStack.Count > 0)
            {
                Console.Write(lettersStack.Pop());
            }
        }
    }
}
