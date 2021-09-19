using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t08.FuelTankPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelQty = double.Parse(Console.ReadLine());
            string discountCard = Console.ReadLine();

            double fuelPrice = 0;

            if (fuelQty >= 20 && fuelQty <= 25)
            {
                if (discountCard == "Yes")
                {
                    switch (fuelType)
                    {
                        case "Gas": fuelPrice = 0.93 - 0.08; break;
                        case "Gasoline": fuelPrice = 2.22 - 0.18; break;
                        case "Diesel": fuelPrice = 2.33 - 0.12; break;
                    }
                }
                else if (discountCard == "No")
                {
                    switch (fuelType)
                    {
                        case "Gas": fuelPrice = 0.93; break;
                        case "Gasoline": fuelPrice = 2.22; break;
                        case "Diesel": fuelPrice = 2.33; break;
                    }
                }
                Console.WriteLine($"{fuelPrice * 0.92 * fuelQty:f2} lv.");
            }
            else if (fuelQty > 25)
            {
                if (discountCard == "Yes")
                {
                    switch (fuelType)
                    {
                        case "Gas": fuelPrice = 0.93 - 0.08; break;
                        case "Gasoline": fuelPrice = 2.22 - 0.18; break;
                        case "Diesel": fuelPrice = 2.33 - 0.12; break;
                    }
                }
                else if (discountCard == "No")
                {
                    switch (fuelType)
                    {
                        case "Gas": fuelPrice = 0.93; break;
                        case "Gasoline": fuelPrice = 2.22; break;
                        case "Diesel": fuelPrice = 2.33; break;
                    }
                }
                Console.WriteLine($"{fuelPrice * 0.9 * fuelQty:f2} lv.");
            }
            else
            {
                if (discountCard == "Yes")
                {
                    switch (fuelType)
                    {
                        case "Gas": fuelPrice = 0.93 - 0.08; break;
                        case "Gasoline": fuelPrice = 2.22 - 0.18; break;
                        case "Diesel": fuelPrice = 2.33 - 0.12; break;
                    }
                }
                else if (discountCard == "No")
                {
                    switch (fuelType)
                    {
                        case "Gas": fuelPrice = 0.93; break;
                        case "Gasoline": fuelPrice = 2.22; break;
                        case "Diesel": fuelPrice = 2.33; break;
                    }
                }
                Console.WriteLine($"{fuelPrice * fuelQty:f2} lv.");
            }
        }
    }
}
