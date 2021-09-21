using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int faceOfVineyard = int.Parse(Console.ReadLine());
            double grapePerSqm = double.Parse(Console.ReadLine());
            int wineNeeded= int.Parse(Console.ReadLine());
            int workers= int.Parse(Console.ReadLine());

            double totalGrapeProduced = faceOfVineyard * grapePerSqm;
            double wineProduction = totalGrapeProduced * 0.4/2.5;

            if (wineProduction<wineNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded-wineProduction)} liters wine needed.");
            }
            else if (wineProduction>-wineNeeded)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduction)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineProduction-wineNeeded)} liters left -> {Math.Ceiling((wineProduction - wineNeeded)/workers)} liters per person.");
            }
        }
    }
}
