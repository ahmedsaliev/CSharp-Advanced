using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            var square = new Square();
            square.Width = 5;
            square.Height = 6; //How it's possible?
            //The right thing is to separate square from rectangle -
            //to make to classes for each item

            var list = new List<IShape>();

            Console.WriteLine(square.GetArea());
        }
    }
}
