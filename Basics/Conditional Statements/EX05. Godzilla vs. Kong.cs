using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace godzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int artists = int.Parse(Console.ReadLine());
            double pricePerArtist = double.Parse(Console.ReadLine());
            double totalPricePerArtists = artists * pricePerArtist;
            double decor = budget * 0.1;

            if (artists > 150)
            {
                totalPricePerArtists *= 0.9;
            }
            double totalExpenses = totalPricePerArtists + decor;
            if (totalExpenses > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(totalExpenses-budget):F2} leva more.");
            }

            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget-totalExpenses):F2} leva left.");
            }

        }
    }
}
