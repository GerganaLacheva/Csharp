using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNumber = int.Parse(Console.ReadLine());
            int row = 1;
            int currentNumber = 1;
            bool isEqual = false;

            while (isEqual==false)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write(currentNumber+" ");
                    currentNumber++;
                    if (currentNumber>targetNumber)
                    {
                        isEqual = true;
                        break;
                    }
                }
                Console.WriteLine();
                row++;
            }

        }
    }
}
