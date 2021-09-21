using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te4.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number<200)
                {
                    p1++;
                }
                else if (number<400)
                {
                    p2++;
                }
                else if (number<600)
                {
                    p3++;
                }
                else if (number<800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }

            }
                double percentConverter1 = (double)p1 / numbers * 100;
                double percentConverter2 = (double)p2 / numbers * 100;
                double percentConverter3 = (double)p3 / numbers * 100;
                double percentConverter4 = (double)p4 / numbers * 100;
                double percentConverter5 = (double)p5 / numbers * 100;

                Console.WriteLine($"{percentConverter1:f2}%");
                Console.WriteLine($"{percentConverter2:f2}%");
                Console.WriteLine($"{percentConverter3:f2}%");
                Console.WriteLine($"{percentConverter4:f2}%");
                Console.WriteLine($"{percentConverter5:f2}%");
        }
    }
}
