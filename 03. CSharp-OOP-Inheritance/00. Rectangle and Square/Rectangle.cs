using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Rectangle : IShape
    {
        public float Height { get; set; }
        public float Width { get; set; }

        public virtual float GetArea()
        {
            return this.Width * this.Height;
        }
    }
}
