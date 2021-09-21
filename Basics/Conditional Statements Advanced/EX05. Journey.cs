using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double discountedBudget = 0;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                switch (season)
                {
                    case "summer":
                        discountedBudget = budget * 0.70;
                        Console.WriteLine($"Camp - {(budget - discountedBudget):f2}"); break;
                    case "winter":
                        discountedBudget = budget * 0.30;
                        Console.WriteLine($"Hotel - {(budget - discountedBudget):f2}"); break;
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                switch (season)
                {
                    case "summer":
                        discountedBudget = budget * 0.60;
                        Console.WriteLine($"Camp - {(budget - discountedBudget):f2}"); break;
                    case "winter":
                        discountedBudget = budget * 0.20;
                        Console.WriteLine($"Hotel - {(budget - discountedBudget):f2}"); break;
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                discountedBudget = budget * 0.10;
                Console.WriteLine($"Hotel - {(budget - discountedBudget):f2}");
            }
        }
    }
}
