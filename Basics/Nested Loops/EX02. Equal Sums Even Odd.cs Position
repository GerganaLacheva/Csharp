using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int currentNumber = i;
                int evenSum = 0;
                int oddSum = 0;
                int count = 0;

                while (currentNumber != 0)
                {
                    int digit = currentNumber % 10;
                    if (count % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                    currentNumber = currentNumber / 10;
                    count++;
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
