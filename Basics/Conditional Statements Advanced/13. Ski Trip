using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string accommodation = Console.ReadLine();
            string feedback = Console.ReadLine();
            double nights = days - 1;
            double finalPrice = 0;

            switch (accommodation)
            {
                case "room for one person":
                    finalPrice = nights * 18; break;
                case "apartment":
                    finalPrice = nights * 25;
                    if (days < 10)
                    {
                        finalPrice *= 0.70;
                    }
                    if (days <= 15)
                    {
                        finalPrice *= 0.65;
                    }
                    if (days > 15)
                    {
                        finalPrice *= 0.50;
                    }
                    break;
                case "president apartment":
                    finalPrice = nights * 35;
                    if (days < 10)
                    {
                        finalPrice *= 0.90;
                    }
                    if (days <= 15)
                    {
                        finalPrice *= 0.85;
                    }
                    if (days > 15)
                    {
                        finalPrice *= 0.80;
                    }
                    break;
            }
            if (feedback == "positive")
            {
                Console.WriteLine($"{ finalPrice * 1.25:f2}");
            }
            else if (feedback == "negative")
            {
                Console.WriteLine($"{finalPrice * 0.90:f2}");
            }
        }
    }
}
