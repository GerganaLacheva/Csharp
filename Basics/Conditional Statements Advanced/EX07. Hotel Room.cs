using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceAppartment = 0;
            double discountStudio = 0;
            double discountAppartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceAppartment = 65;
                    break;
                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceAppartment = 68.70;
                    break;
                case "July":
                case "August":
                    priceStudio = 76;
                    priceAppartment = 77;
                    break;
            }
            if (nights > 14 && (month == "May" || month == "October"))
            {
                discountStudio = 0.3;
            }
            else if (nights > 7 && (month == "May" || month == "October"))
            {
                discountStudio = 0.05;
            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                discountStudio = 0.2;
            }
            if (nights > 14)
            {
                discountAppartment = 0.1;
            }
            double finalStudioPrice = priceStudio * nights * (1 - discountStudio);
            double finalAppartmentPrice = priceAppartment * nights * (1 - discountAppartment);
            Console.WriteLine($"Apartment: {finalAppartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {finalStudioPrice:f2} lv.");
        }
    }
}
