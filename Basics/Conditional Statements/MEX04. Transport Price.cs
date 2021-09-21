using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string tariff = Console.ReadLine();


            if (distance < 20)
            {
                switch (tariff)
                {
                    case "day": Console.WriteLine($"{ (0.7 + 0.79 * distance):f2}"); break;
                    case "night": Console.WriteLine($"{ (0.7 + 0.9 * distance):f2}"); break;
                }
            }
            else if (distance >= 100)
            {
                Console.WriteLine($"{ distance * 0.06:f2}");
            }
            else if (distance < 100 && distance >= 20)
            {
                Console.WriteLine($"{distance * 0.09:f2}");
            }
        }
    }
}
