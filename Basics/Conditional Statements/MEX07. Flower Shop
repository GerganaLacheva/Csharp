using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int flower1Qty = int.Parse(Console.ReadLine());
            int flower2Qty = int.Parse(Console.ReadLine());
            int flower3Qty = int.Parse(Console.ReadLine());
            int flower4Qty = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double orderValue = (flower1Qty * 3.25 + flower2Qty * 4 + flower3Qty * 3.5 + flower4Qty * 8) * 0.95;
            if (orderValue >= presentPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(orderValue - presentPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - orderValue)} leva.");
            }
        }
    }
}
