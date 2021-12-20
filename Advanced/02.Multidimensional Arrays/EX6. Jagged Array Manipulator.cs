using System;
using System.Linq;

namespace EX6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] matrix = new double[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                if (matrix[i - 1].Length == matrix[i].Length)
                {
                    matrix[i - 1] = matrix[i - 1].Select(x => x * 2).ToArray();
                    matrix[i] = matrix[i].Select(x => x * 2).ToArray();
                }
                else
                {
                    matrix[i - 1] = matrix[i - 1].Select(x => x / 2).ToArray();
                    matrix[i] = matrix[i].Select(x => x / 2).ToArray();
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split();
                string action = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                double value = double.Parse(tokens[3]);

                if (row < 0 || row > n - 1 || col < 0 || matrix[row].Length - 1 < col)
                {
                    command = Console.ReadLine();
                    continue;
                }
                switch (action)
                {
                    case "Add":
                        matrix[row][col] += value;
                        break;
                    case "Subtract":
                        matrix[row][col] -= value;
                        break;
                }

                        command = Console.ReadLine();
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ",matrix[i]));
            }
        }
    }
}
//6.Jagged Array Manipulator
//Create a program that populates, analyzes and manipulates the elements of a matrix with unequal length of its rows.
//First you will receive an integer N equal to the number of rows in your matrix.
//On the next N lines, you will receive sequences of integers, separated by a single space. Each sequence is a row in the matrix.
//After populating the matrix, start analyzing it. If a row and the one below it have equal length, multiply each element in both of them by 2, otherwise - divide by 2.
//Then, you will receive commands. There are three possible commands:
//•	"Add {row} {column} {value}" - add { value}
//to the element at the given indexes, if they are valid
//•	"Subtract {row} {column} {value}" - subtract {value} from the element at the given indexes, if they are valid
//•	"End" - print the final state of the matrix (all elements separated by a single space) and stop the program
//Input
//•	On the first line, you will receive the number of rows of the matrix - integer N
//•	On the next N lines, you will receive each row - sequence of integers, separated by a single space
//•	{value} will always be integer number
//•	Then you will be receiving commands until reading "End"
//Output
//•	The output should be printed on the console and it should consist of N lines
//•	Each line should contain a string representing the respective row of the final matrix, elements separated by a single space
//Constraints
//•	The number of rows N of the matrix will be integer in the range [2 … 12]
//•	The input will always follow the format above
//•	Think about data types 
//Examples
//Input	
//5
//10 20 30
//1 2 3
//2
//2
//10 10
//End	
//
//Output
//20 40 60
//1 2 3
//2
//2
//5 5 

//Input
//5
//10 20 30
//1 2 3
//2
//2
//10 10
//Add 0 10 10
//Add 0 0 10
//Subtract -3 0 10
//Subtract 3 0 10
//End	
//
//Output
//30 40 60
//1 2 3
//2
//-8
//5 5
