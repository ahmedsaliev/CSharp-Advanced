using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_4._Telephony
{
    public class Smartphone : ICallingFunctionality, IBrowsingFunctionality
    {
        private string input;

        public Smartphone(string input)
        {
            this.input = input;
        }

        public string Browse()
        {
            if (input.Any(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {this.input}!";
        }

        public string Call()
        {
            if (!input.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Calling... {this.input}";
        }
    }
}