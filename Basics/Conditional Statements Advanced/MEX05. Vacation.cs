using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = "";
            string accommodation="";

            if (budget<=1000)
            {
                accommodation = "Camp";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        budget *= 0.65;break;
                    case "Winter":
                        location = "Morocco";
                        budget *= 0.45;break;
                }
            }
            else if (budget>1000 && budget<=3000)
            {
                accommodation = "Hut";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        budget *= 0.8; break;
                    case "Winter":
                        location = "Morocco";
                        budget *= 0.6; break;
                }
            }
            else if (budget>3000)
            {
                accommodation = "Hotel";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        budget *= 0.9; break;
                    case "Winter":
                        location = "Morocco";
                        budget *= 0.9; break;
                }
            }
            Console.WriteLine($"{location} - {accommodation} - {budget:f2}");
        }
    }
}
