using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class RandomList<T> : List<T>
    {
        private Random random;

        public RandomList()
        {
            this.random = new Random();
        }

        public T RemoveRandom()
        {
            var index = this.random.Next(0, this.Count);
            var element = this[index];
            this.RemoveAt(index);
            return element;
        }
    }
}