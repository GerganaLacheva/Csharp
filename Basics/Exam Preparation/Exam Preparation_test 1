using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            double processorPrice = double.Parse(Console.ReadLine());
            double videocardPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            int qtyRam = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double fxRate = 1.57;

            double totalPrice = ((processorPrice + videocardPrice) * fxRate) * (1 - discount) + ramPrice * qtyRam * fxRate;

            Console.WriteLine($"Money needed - {totalPrice:f2} leva.");
        }
    }
}
