namespace Inheritance
{
    class Cat : Animal
    {
        public Cat(string name, int age, int miceKilled)
            : base(name, age)
        {
            this.MiceKilled = MiceKilled;
        }

        public Cat(string name)
            : base(name, 0)
        {
        }

        public int MiceKilled { get; set; }

        public string Meow()
        {
            return "Meow!";
        }
    }
}
