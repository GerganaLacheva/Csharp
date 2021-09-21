using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int seaPrice = 680;
            const int mountainPrice = 499;

            int seaPackets = int.Parse(Console.ReadLine());
            int mountainPackets = int.Parse(Console.ReadLine());
            int profit = 0;

            string packetName = Console.ReadLine();

            while (packetName != "Stop")
            {
                if (packetName == "sea")
                {
                    if (seaPackets > 0)
                    {
                        profit += seaPrice;
                        seaPackets--;
                    }
                }
                else if (packetName == "mountain")
                {
                    if (mountainPackets > 0)
                    {
                        profit += mountainPrice;
                        mountainPackets--;
                    }
                }
                if (mountainPackets <= 0 && seaPackets <= 0)
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    break;
                }
                packetName = Console.ReadLine();
            }
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
