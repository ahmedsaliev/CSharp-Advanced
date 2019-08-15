using System;
using System.Collections.Generic;

namespace Inheritance
{
    public static class ListExtensions //must be static
    {
        private static Random random = new Random();

        public static T RemoveRandomElement<T>(this List<T> list)
        {
            var index = random.Next(0, list.Count);
            var element = list[index];
            list.RemoveAt(index);
            return element;
        }
    }
}
