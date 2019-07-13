using System;
using System.Linq;

namespace _01._Absolute_Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] matrix = new long[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse).ToArray();
            }
            long primaryDiagonalSum = 0;
            for (int i = 0; i < n; i++)
            {
                primaryDiagonalSum += matrix[i][i];
            }
            long secondaryDiagonalSum = 0;
            for (int i = 0, j = n - 1; i < n; i++, j--)
            {
                secondaryDiagonalSum += matrix[i][j];
            }
            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}