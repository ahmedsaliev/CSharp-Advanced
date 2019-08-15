using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Square : Rectangle
    {
        public float Side => this.Width;

        public override float GetArea()
        {
            return this.Side * this.Side;
        }
    }
}
