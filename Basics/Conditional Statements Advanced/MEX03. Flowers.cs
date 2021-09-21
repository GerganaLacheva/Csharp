using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtyChrysanthemum = int.Parse(Console.ReadLine());
            int qtyRoses = int.Parse(Console.ReadLine());
            int qtyTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            int totalFlowers = qtyChrysanthemum + qtyRoses + qtyTulips;
            double priceChrysanthemum = 0;
            double priceRoses = 0;
            double priceTulips = 0;
            double priceBouquet = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    priceChrysanthemum = 2;
                    priceRoses = 4.1;
                    priceTulips = 2.5;
                    break;
                case "Autumn":
                case "Winter":
                    priceChrysanthemum = 3.75;
                    priceRoses = 4.5;
                    priceTulips = 4.15;
                    break;
            }
            priceBouquet = priceChrysanthemum * qtyChrysanthemum + priceRoses * qtyRoses + priceTulips * qtyTulips;
            if (holiday=="Y")
            {
                priceBouquet *= 1.15;
            }
            if (season=="Spring" && qtyTulips>7)
            {
                priceBouquet *= 0.95;
            }
            if (season=="Winter" && qtyRoses>=10)
            {
                priceBouquet *= 0.9;
            }
            if (totalFlowers>20)
            {
                priceBouquet *= 0.8;
            }
            Console.WriteLine($"{(priceBouquet+2):f2}");
        }
    }
}
