using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double m2 = double.Parse(Console.ReadLine());
            double priceM2 = 7.61;
            double price = priceM2 * m2;
            double discount = price * 0.18;
            double finalPrice = price - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
         }
    }
}
