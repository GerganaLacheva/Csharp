using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double convert = change * 100; //1.23->123.00
            int cents = (int)convert;//123.00->123

            int coinsCounter = 0;

            while (cents > 0)
            {
                if (cents - 200 >= 0)
                {
                    coinsCounter++;
                    cents -= 200;
                }
                else if (cents - 100 >= 0)
                {
                    coinsCounter++;
                    cents -= 100;
                }
                else if (cents - 50 >= 0)
                {
                    coinsCounter++;
                    cents -= 50;
                }
                else if (cents - 20 >= 0)
                {
                    coinsCounter++;
                    cents -= 20;
                }
                else if (cents - 10 >= 0)
                {
                    coinsCounter++;
                    cents -= 10;
                }
                else if (cents - 5 >= 0)
                {
                    coinsCounter++;
                    cents -= 5;
                }
                else if (cents - 2 >= 0)
                {
                    coinsCounter++;
                    cents -= 2;
                }
                else if (cents - 1 >= 0)
                {
                    coinsCounter++;
                    cents -= 1;
                }
            }
            Console.WriteLine(coinsCounter);

        }
    }
}
