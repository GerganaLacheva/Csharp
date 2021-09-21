using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneySaved = double.Parse(Console.ReadLine());

            int days = 0;
            int spentCounter = 0;

            while (spentCounter!=5)
            {
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;
                if (input=="save")
                {
                    moneySaved += money;
                    spentCounter = 0;
                }
                else if (input=="spend")
                {
                    spentCounter++;
                    if (money>moneySaved)
                    {
                        moneySaved = 0;
                    }
                    else
                    {
                        moneySaved -= money;
                    }
                }
                if (moneySaved>=moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    return;
                }

            }
            Console.WriteLine($"You can't save the money.");
            Console.WriteLine(days);

        }
    }
}
