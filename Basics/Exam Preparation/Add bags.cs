using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Add_Bags_07._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBagOver20kg = double.Parse(Console.ReadLine());
            double weightOfBag = double.Parse(Console.ReadLine());
            int daysBeforeTrip = int.Parse(Console.ReadLine());
            int numberOfBags = int.Parse(Console.ReadLine());

            double expenses = 0;

            if (weightOfBag < 10)
            {
                if (daysBeforeTrip > 30)
                {
                    expenses = priceBagOver20kg * 0.2 * 1.1 * numberOfBags;
                }
                else if (daysBeforeTrip >= 7 && daysBeforeTrip < 30)
                {
                    expenses = priceBagOver20kg * 0.2 * 1.15 * numberOfBags;
                }
                else if (daysBeforeTrip < 7)
                {
                    expenses = priceBagOver20kg * 0.2 * 1.4 * numberOfBags;
                }
            }
            else if (weightOfBag >= 10 && weightOfBag <= 20)
            {
                if (daysBeforeTrip > 30)
                {
                    expenses = priceBagOver20kg * 0.5 * 1.1 * numberOfBags;
                }
                else if (daysBeforeTrip >= 7 && daysBeforeTrip < 30)
                {
                    expenses = priceBagOver20kg * 0.5 * 1.15 * numberOfBags;
                }
                else if (daysBeforeTrip < 7)
                {
                    expenses = priceBagOver20kg * 0.5 * 1.4 * numberOfBags;
                }
            }
            else if (weightOfBag > 20)
            {
                if (daysBeforeTrip > 30)
                {
                    expenses = priceBagOver20kg * 1.1 * numberOfBags;
                }
                else if (daysBeforeTrip >= 7 && daysBeforeTrip < 30)
                {
                    expenses = priceBagOver20kg * 1.15 * numberOfBags;
                }
                else if (daysBeforeTrip < 7)
                {
                    expenses = priceBagOver20kg * 1.4 * numberOfBags;
                }
            }
            Console.WriteLine($"The total price of bags is: {expenses:f2} lv. ");
        }
    }
}
