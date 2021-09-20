using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysStay = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            int numberOfNights = daysStay - 1;
            double pricePerNight = 0;
            double totalPrice = 0;

            if (numberOfNights < 10)
            {
                switch (roomType)
                {
                    case "room for one person":
                        pricePerNight = 18;
                        totalPrice = pricePerNight * numberOfNights;
                        break;
                    case "apartment":
                        pricePerNight = 25 * 0.70;
                        totalPrice = pricePerNight * numberOfNights;
                        break;
                    case "president apartment":
                        pricePerNight = 35 * 0.90;
                        totalPrice = pricePerNight * numberOfNights;
                        break;
                }
            }
            else if (numberOfNights >= 10 && numberOfNights <= 15)
            {
                switch (roomType)
                {
                    case "room for one person":
                        pricePerNight = 18;
                        totalPrice = pricePerNight * numberOfNights;
                        break;
                    case "apartment":
                        pricePerNight = 25 * 0.65;
                        totalPrice = pricePerNight * numberOfNights;
                        break;
                    case "president apartment":
                        pricePerNight = 35 * 0.85;
                        totalPrice = pricePerNight * numberOfNights;
                        break;
                }
            }
            else if (numberOfNights > 15)
            {
                switch (roomType)
                {
                    case "room for one person":
                        pricePerNight = 18;
                        totalPrice = pricePerNight * numberOfNights;
                        break;
                    case "apartment":
                        pricePerNight = 25 * 0.5;
                        totalPrice = pricePerNight * numberOfNights;
                        break;
                    case "president apartment":
                        pricePerNight = 35 * 0.8;
                        totalPrice = pricePerNight * numberOfNights;
                        break;

                }
            }


            if (feedback== "positive")
            {
                totalPrice *= 1.25;
            }
            else if (feedback== "negative")
            {
                totalPrice *= 0.90;
            }
            Console.WriteLine($"{ totalPrice:f2}");
        }
    }
}
