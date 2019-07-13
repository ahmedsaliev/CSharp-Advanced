using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main ()
        {
            string text = "121a. 5656b. 251c";
            string numbers = new string (text.Where(char.IsDigit).ToArray());
            Console.WriteLine(numbers);
            Console.WriteLine("------------------------------");

            int[] array = { 1, 2, 2, 3, 3, 3, 4, 5 };
            array = array.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine("------------------------------");

            array = array.Distinct().ToArray();
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine("------------------------------");

            array = array.OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine("------------------------------");

            array = array.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine("------------------------------");
        }
    }
}
