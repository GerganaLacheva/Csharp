using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PastryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string pastryType = Console.ReadLine();
            int qtyPastries = int.Parse(Console.ReadLine());
            int date = int.Parse(Console.ReadLine());

            double price = 0;

            switch (pastryType)
            {
                case "Cake":
                    if (date<=15)
                    {
                        price = 24*qtyPastries;
                    }
                    else
                    {
                        price = 28.7*qtyPastries;
                    }

                    break;
                case "Souffle":
                    if (date <= 15)
                    {
                        price =6.66 * qtyPastries;
                    }
                    else
                    {
                        price = 9.8 * qtyPastries;
                    }

                    break;
                case "Baklava":
                    if (date <= 15)
                    {
                        price = 12.6 * qtyPastries;
                    }
                    else
                    {
                        price = 16.98 * qtyPastries;
                    }

                    break;
            }
            if (date<=22)
            {
                if (price>=100 && price<=200)
                {
                    price *= 0.85;
                }
                else if (price>200)
                {
                    price *= 0.75;
                }
            }
                if (date<=15)
                {
                    price *= 0.9;
                }
            Console.WriteLine($"{price:f2}");
        }
    }
}
