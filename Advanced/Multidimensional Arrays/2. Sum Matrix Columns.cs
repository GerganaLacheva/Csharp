using System;
using System.Linq;
 
namespace Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int[] size = line.Split(',').Select(int.Parse).ToArray();
            int rows = size[0];
            int columns = size[1];
            int[] sumColumns = new int[columns];
                for (int i = 0; i < rows; i++)
            {
                string currentLine = Console.ReadLine();
                int[] currentArray = currentLine.Split().Select(int.Parse).ToArray();
                for (int j = 0; j <columns; j++)
                {
                    sumColumns[j] += currentArray[j];
                }
            }
            foreach (int number in sumColumns)
            {
                Console.WriteLine(number);
            }
        }
    }
}
