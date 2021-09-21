using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string location = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double finalSum = 0;

            if (location == "Sofia")
            {
                switch (product)
                {
                    case "coffee": finalSum = qty * 0.5; break;
                    case "water": finalSum = qty * 0.8; break;
                    case "beer": finalSum = qty * 1.2; break;
                    case "sweets": finalSum = qty * 1.45; break;
                    case "peanuts": finalSum = qty * 1.6; break;
                }
                Console.WriteLine(finalSum);
            }
            else if (location == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee": finalSum = qty * 0.4; break;
                    case "water": finalSum = qty * 0.7; break;
                    case "beer": finalSum = qty * 1.15; break;
                    case "sweets": finalSum = qty * 1.3; break;
                    case "peanuts": finalSum = qty * 1.5; break;
                }
                Console.WriteLine(finalSum);
            }
            else if (location == "Varna")
            {
                switch (product)
                {
                    case "coffee": finalSum = qty * 0.45; break;
                    case "water": finalSum = qty * 0.7; break;
                    case "beer": finalSum = qty * 1.1; break;
                    case "sweets": finalSum = qty * 1.35; break;
                    case "peanuts": finalSum = qty * 1.55; break;
                }
                Console.WriteLine(finalSum);
            }

        }
    }
}
