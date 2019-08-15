using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class StringStack : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public void PushRange(IEnumerable<string> data)
        //public void PushRange(params string[] data)
        {
            foreach (var item in data)
            {
                this.Push(item);
            }
        }
    }
}
