namespace Exercise
{
    public class Cat
    {
        private string name;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"Cat name is {this.Name}, {this.Age} years old!";
        }
    }
}