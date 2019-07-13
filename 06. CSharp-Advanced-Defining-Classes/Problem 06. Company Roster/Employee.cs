namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public Employee(string name, double salary, string position, string departament, string email, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = departament;
            this.Email = email;
            this.Age = age;
        }

        public Employee(string name, double salary, string position, string departament, int age)
            : this(name, salary, position, departament, "n/a", age)
        {
        }

        public Employee(string name, double salary, string position, string departament, string email)
            : this(name, salary, position, departament, email, -1)
        {
        }

        public Employee(string name, double salary, string position, string departament)
            : this(name, salary, position, departament, "n/a", -1)
        {
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Salary:f2} {this.Email} {this.Age}";
        }
    }
}