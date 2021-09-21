using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te5.Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }
            double conv1 = (double)p1 / numbers * 100;
            double conv2 = (double)p2 / numbers * 100;
            double conv3 = (double)p3 / numbers * 100;

            Console.WriteLine($"{conv1:f2}%");
            Console.WriteLine($"{conv2:f2}%");
            Console.WriteLine($"{conv3:f2}%");
        }
    }
}
