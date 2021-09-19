using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePuzzles = 2.6;
            double priceDolls = 3;
            double priceBears = 4.1;
            double priceMinions = 8.2;
            double priceTrucks = 2;
            double priceExcursion = double.Parse(Console.ReadLine());
            int qtyPuzzles = int.Parse(Console.ReadLine());
            int qtyDolls = int.Parse(Console.ReadLine());
            int qtyBears = int.Parse(Console.ReadLine());
            int qtyMinions = int.Parse(Console.ReadLine());
            int qtyTrucks = int.Parse(Console.ReadLine());
                      
            double total = qtyPuzzles * pricePuzzles + qtyDolls * priceDolls + qtyBears * priceBears + qtyMinions * priceMinions + qtyTrucks * priceTrucks;
            int qtyToys = qtyPuzzles + qtyDolls + qtyBears + qtyMinions + qtyTrucks;

            if (qtyToys>=50)
            {
                total = total * 0.75;
            }

            total = total * 0.9;

            if (total>=priceExcursion)
            {
                Console.WriteLine($"Yes! {total-priceExcursion:F2} lv left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! {priceExcursion-total:F2} lv needed.");
            }
        }
    }
}
