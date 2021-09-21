using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana": Console.WriteLine($"{qty * 2.50:f2}"); ; break;
                    case "apple": Console.WriteLine($"{qty * 1.20:f2}"); ; break;
                    case "orange": Console.WriteLine($"{qty * 0.85:f2}"); ; break;
                    case "grapefruit": Console.WriteLine($"{qty * 1.45:f2}"); ; break;
                    case "kiwi": Console.WriteLine($"{qty * 2.70:f2}"); ; break; ;
                    case "pineapple": Console.WriteLine($"{qty * 5.50:f2}"); ; break;
                    case "grapes": Console.WriteLine($"{qty * 3.85:f2}"); ; break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana": Console.WriteLine($"{qty * 2.70:f2}"); ; break;
                    case "apple": Console.WriteLine($"{qty * 1.25:f2}"); ; break;
                    case "orange": Console.WriteLine($"{qty * 0.90:f2}"); ; break;
                    case "grapefruit": Console.WriteLine($"{qty * 1.60:f2}"); ; break;
                    case "kiwi": Console.WriteLine($"{qty * 3.00:f2}"); ; break; ;
                    case "pineapple": Console.WriteLine($"{qty * 5.60:f2}"); ; break;
                    case "grapes": Console.WriteLine($"{qty * 4.20:f2}"); ; break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }

    }
}

