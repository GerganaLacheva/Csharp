using System;
using System.Linq;

namespace EX2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[dimensions[0], dimensions[1]];

            for (int i = 0; i < dimensions[0]; i++)
            {
                char[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int j = 0; j < dimensions[1]; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }
            int squareSubMatrixCount = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] &&
                        matrix[i, j] == matrix[i + 1, j + 1] &&
                        matrix[i, j] == matrix[i + 1, j])
                    {
                        squareSubMatrixCount++;
                    }
                }
            }
            Console.WriteLine(squareSubMatrixCount);
        }
    }
}
//2X2 Squares in Matrix
//Find the count of 2 x 2 squares of equal chars in a matrix.
//Input
//•	On the first line, you are given the integers rows and cols – the matrix’s dimensions
//•	Matrix characters come at the next rows lines (space separated)
//Output
//•	Print the number of all the squares matrixes you have found
//Examples
//Input		
//3 4
//A B B D
//E B B B
//I J B B	
//
//Output
//2	
//
//Comments
//Two 2 x 2 squares of equal cells:
//A B B D	A B B D
//E B B B	E B B B
//I J B B	I J B B
//
//Input
//2 2
//a b
//c d	
//
//Output
//0	
//
//Comments
//No 2 x 2 squares of equal cells exist.
