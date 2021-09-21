using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double totalSeats = r*c;
            double price = 0;

            switch (projectionType)
            {
                case "Premiere":
                    price = 12;
                    Console.WriteLine($"{totalSeats*price:f2} leva");
                    break;

                case "Normal":
                    price = 7.50;
                    Console.WriteLine($"{totalSeats * price:f2} leva");
                    break;

                case "Discount":
                    price = 5;
                    Console.WriteLine($"{totalSeats * price:f2} leva");
                    break;
            }

        }
    }
}
