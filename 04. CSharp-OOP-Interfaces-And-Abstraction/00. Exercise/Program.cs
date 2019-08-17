using System;

namespace Exercise
{
    class Program
    {
        static void Main()
        {
            Cat cat = new Cat("Ivan", 5);
            cat.Name = "Pesho";
            cat.Age = 3;
           
            Console.WriteLine(cat);
        }
    }
}