using System;
using System.Collections.Generic;
using System.Text;

namespace RadioDatabase
{
    public static class Validation
    {
        public static void IsValidSongName(string[] input)
        {
            if (input.Length != 3)
            {
                throw new ArgumentException("Invalid song.");
            }
        }

        public static void IsValidSongLength(string[] input)
        {
            if (input.Length != 2)
            {
                throw new ArgumentException("Invalid song length.");
            }
        }
    }
}
