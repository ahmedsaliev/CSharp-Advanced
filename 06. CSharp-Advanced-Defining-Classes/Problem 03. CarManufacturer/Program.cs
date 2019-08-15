using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person() : this("No name", 1)
        {
        }

        public Person(int age) : this("No name", age)
        {
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
//---------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> lisfOfPeople = new List<Person>();

        public void AddMember(Person member)
        {
            this.lisfOfPeople.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.lisfOfPeople
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();
        }
    }
}
//---------------------------------------------------
using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int membersCount = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < membersCount; i++)
            {
                string[] personArgs = Console.ReadLine()
                    .Split();
                string name = personArgs[0];
                int age = int.Parse(personArgs[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine(oldestMember);
        }
    }
}