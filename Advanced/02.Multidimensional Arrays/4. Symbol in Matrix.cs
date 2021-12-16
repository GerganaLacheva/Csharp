using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                char[] arr = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {

                    matrix[i, j] = arr[j];

                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
//4.Symbol in Matrix
//Create a program that reads N, number representing rows and cols of a matrix. On the next N lines, you will receive rows of the matrix. Each row consists of ASCII characters. After that, you will receive a symbol. Find the first occurrence of that symbol in the matrix and print its position in the format: "({row}, {col})".If there is no such symbol print an error message 
//"{symbol} does not occur in the matrix "

//Examples
//Input	        Output
//3             (2, 1)
//ABC
//DEF
//X!@
//!
//
//Input	        Output	
//4             4 does not occur in the matrix
//asdd
//xczc
//qwee
//qefw
//4	
