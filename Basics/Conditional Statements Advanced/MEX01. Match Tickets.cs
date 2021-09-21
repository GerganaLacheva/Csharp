using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string cathegory = Console.ReadLine();
            int fans = int.Parse(Console.ReadLine());

            //double VIP = 499.99;
            //double Normal = 249.99;

            double transportationPrice = 0;
            double totalCost = 0;

            if (fans >= 1 && fans <= 4)
            {
                transportationPrice = budget * 0.75;
            }
            else if (fans >= 5 && fans <= 9)
            {
                transportationPrice = budget * 0.60;
            }
            else if (fans >= 10 && fans <= 24)
            {
                transportationPrice = budget * 0.50;
            }
            else if (fans >= 25 && fans <= 49)
            {
                transportationPrice = budget * 0.40;
            }
            else if (fans >= 50)
            {
                transportationPrice = budget * 0.25;
            }
            switch (cathegory)
            {
                case "Normal":
                    totalCost = 249.99 * fans + transportationPrice;
                    if (budget >= totalCost)
                    {
                        Console.WriteLine($"Yes! You have {(budget - totalCost):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(totalCost - budget):f2} leva.");
                    }
                    break;
                case "VIP":
                    totalCost = 499.99 * fans + transportationPrice;
                    if (budget >= totalCost)
                    {
                        Console.WriteLine($"Yes! You have {(budget - totalCost):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(totalCost - budget):f2} leva.");
                    }
                    break;
            }
        }
    }
}
