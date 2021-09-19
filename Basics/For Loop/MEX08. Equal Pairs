using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tae8.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            int curentSum = numberOne + numberTwo;
            int curentDiff = 0;
            bool chek = true;

            for (int i = 0; i < countNumbers - 1; i++)
            {
                numberOne = int.Parse(Console.ReadLine());
                numberTwo = int.Parse(Console.ReadLine());
                int curent = numberOne + numberTwo;

                if (curent != curentSum)
                {
                    int diff = Math.Abs(curent - curentSum);
                    if (diff > curentDiff)
                    {
                        curentDiff = diff;
                    }
                    curentSum = curent;
                    chek = false;
                }
            }
            if (chek)
            {
                Console.WriteLine($"Yes, value={curentSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={curentDiff}");
            }
        }
    }
}
