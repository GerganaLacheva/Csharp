using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dimensions = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int i = 0; i < dimensions[0]; i++)
            {

                string[] arr = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < dimensions[1]; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "swap" && tokens.Length == 5)
                {
                    int row1 = int.Parse(tokens[1]);
                    int col1 = int.Parse(tokens[2]);
                    int row2 = int.Parse(tokens[3]);
                    int col2 = int.Parse(tokens[4]);
                    if (row1 >= 0 && col1 >= 0
                        && row2 >= 0 && col2 >= 0
                        && row1 < dimensions[0] && row2 < dimensions[0]
                        && col1 < dimensions[1] && col2 < dimensions[1])
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        for (int i = 0; i < dimensions[0]; i++)
                        {
                            for (int j = 0; j < dimensions[1]; j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine();
            }
        }
    }
}
//4.Matrix Shuffling
//Write a program which reads a string matrix from the console and performs certain operations with its elements. User input is provided in a similar way like in the problems above – first you read the dimensions and then the data. 
//Your program should then receive commands in format: "swap row1 col1 row2 col2" where row1, col1, row2, col2 are coordinates in the matrix. In order for a command to be valid, it should start with the "swap" keyword along with four valid coordinates (no more, no less). You should swap the values at the given coordinates (cell [row1, col1] with cell[row2, col2]) and print the matrix at each step (thus you'll be able to check if the operation was performed correctly). 
//If the command is not valid (doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist), print "Invalid input!" and move on to the next command. Your program should finish when the string "END" is entered.
//Examples
//Input	
//2 3
//1 2 3
//4 5 6
//swap 0 0 1 1
//swap 10 9 8 7
//swap 0 1 1 0
//END	
//
//Output
//5 2 3
//4 1 6
//Invalid input!
//5 4 3
//2 1 6

//Input
//1 2
//Hello World
//0 0 0 1
//swap 0 0 0 1
//swap 0 1 0 0
//END	
//
//Output
//Invalid input!
//World Hello
//Hello World
