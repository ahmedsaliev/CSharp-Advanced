using System;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            var stack = new StringStack();

            stack.PushRange(new[] { "1", "2", "3" });
            //stack.PushRange("1", "2", "3")
        }
    }
}
