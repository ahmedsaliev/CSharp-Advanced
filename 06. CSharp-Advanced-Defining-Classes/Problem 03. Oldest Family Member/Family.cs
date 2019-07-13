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