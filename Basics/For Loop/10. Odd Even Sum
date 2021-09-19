using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t10.OddEvenSum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum1 += number;
                }
                else
                {
                    sum2 += number;
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
