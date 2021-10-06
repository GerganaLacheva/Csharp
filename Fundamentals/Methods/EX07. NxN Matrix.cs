using System;

namespace EX07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);
        }

        private static void PrintMatrix(int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}
//7.NxN Matrix
//Create a method that receives a single integer n and prints an NxN matrix using this number as a filler.
//Examples
//Input	Output
//3	    3 3 3
//      3 3 3
//      3 3 3
