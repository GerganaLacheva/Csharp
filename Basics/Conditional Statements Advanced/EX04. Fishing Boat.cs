using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double discountedPrice = 0;

            switch (season)
            {
                case "Spring":
                    if (fishermen<=6)
                    {
                        discountedPrice = 3000 * 0.90;
                    }
                    else if (fishermen>=7 && fishermen<=11)
                    {
                        discountedPrice = 3000 * 0.85;
                    }
                    else if (fishermen>=12)
                    {
                        discountedPrice = 3000 * 0.75;
                    }
                    break;
                case "Summer":
                    //if (fishermen <= 6)
                    //{
                    //    discountedPrice = 4200 * 0.90;
                    //}
                    //else if (fishermen >= 7 && fishermen <= 11)
                    //{
                    //    discountedPrice = 4200 * 0.85;
                    //}
                    //else if (fishermen >= 12)
                    //{
                    //    discountedPrice = 4200 * 0.75;
                    //}
                    //break;
                case "Autumn":
                    if (fishermen <= 6)
                    {
                        discountedPrice = 4200 * 0.90;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        discountedPrice = 4200 * 0.85;
                    }
                    else if (fishermen >= 12)
                    {
                        discountedPrice = 4200 * 0.75;
                    }
                    break;
                case "Winter":
                    if (fishermen <= 6)
                    {
                        discountedPrice = 2600 * 0.90;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        discountedPrice = 2600 * 0.85;
                    }
                    else if (fishermen >= 12)
                    {
                        discountedPrice = 2600 * 0.75;
                    }
                    break;

                default:
                    break;
            }
            if (fishermen % 2==0 && season!= "Autumn")
            {
                discountedPrice *= 0.95;
            }
            if (budget>=discountedPrice)
            {
                Console.WriteLine($"Yes! You have {(budget-discountedPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(discountedPrice-budget):f2} leva.");
            }
        }
    }
}
