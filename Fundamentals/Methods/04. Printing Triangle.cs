using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                Output(i);
            }
            for (int i = input-1; i > 0; i--)
            {
                Output(i);
            }

        }

        static void Output(int numbers)
        {
            for (int i = 1; i <= numbers; i++)
            {
                Console.Write($"{i} ");
            }
                Console.WriteLine();
        }
    }
}
//4.Printing Triangle
//Create a method for printing triangles as shown below:
//Examples
//Input	
//3	
//Output
//1
//1 2
//1 2 3
//1 2
//1
