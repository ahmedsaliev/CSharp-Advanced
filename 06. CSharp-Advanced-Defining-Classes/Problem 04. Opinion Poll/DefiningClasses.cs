using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            List<Person> nameList = new List<Person>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] inputLine = Console.ReadLine()
                    .Split();

                string name = inputLine[0];
                int age = int.Parse(inputLine[1]);
                Person person = new Person(name, age);
                nameList.Add(person);
            }

            List<Person> peopleOverThirty = nameList
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, peopleOverThirty));
        }
    }
}