using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string carType = "";

            if (budget <= 100)
            {
                Console.WriteLine("Economy class");
                switch (season)
                {
                    case "Summer":
                        budget *= 0.35;
                        carType = "Cabrio";
                        break;
                    case "Winter":
                        budget *= 0.65;
                        carType = "Jeep";
                        break;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                Console.WriteLine("Compact class");
                switch (season)
                {
                    case "Summer":
                        budget *= 0.45;
                        carType = "Cabrio";
                        break;
                    case "Winter":
                        budget *= 0.8;
                        carType = "Jeep";
                        break;
                }
            }
            else if (budget > 500)
            {
                Console.WriteLine("Luxury class");
                switch (season)
                {
                    case "Summer":
                    case "Winter":
                        budget *= 0.9;
                        carType = "Jeep";
                        break;
                }
            }
            Console.WriteLine($"{carType} - {budget:f2}");
        }
    }
}
