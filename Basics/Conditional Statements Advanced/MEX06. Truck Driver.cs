using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());
            double salaryPerKm = 0;

            if (kmPerMonth <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        salaryPerKm = 0.75; break;
                    case "Summer":
                        salaryPerKm = 0.9; break;
                    case "Winter":
                        salaryPerKm = 1.05; break;
                }
            }
            else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        salaryPerKm = 0.95; break;
                    case "Summer":
                        salaryPerKm = 1.1; break;
                    case "Winter":
                        salaryPerKm = 1.25; break;
                }
            }
            else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
            {
                salaryPerKm = 1.45;
            }
            Console.WriteLine($"{(salaryPerKm*kmPerMonth*4*0.9):f2}");
        }
    }
}
