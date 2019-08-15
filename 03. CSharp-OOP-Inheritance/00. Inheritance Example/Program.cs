using System;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            //var dog = new Dog
            //{
            //    Name = "Ivan",
            //    Age = 5
            //};

            //var cat = new Cat
            //{
            //    Name = "Gosho",
            //    Age = 15
            //};

            var dog = new Dog("Ivan", 5);
            var cat = new Cat("Gosho", 15, 997);
        }
    }
}
