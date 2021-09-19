using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationCounter = 0;

            for (int number1 = startNumber; number1 <= endNumber; number1++)
            {
                for (int number2 = startNumber; number2 <= endNumber; number2++)
                {
                    combinationCounter++;
                    if (number1 + number2 == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({number1} + {number2} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");
        }
    }
}
