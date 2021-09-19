using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tae7.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacityStadium = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());

            int fansA = 0;
            int fansB = 0;
            int fansV = 0;
            int fansG = 0;

            for (int i = 1; i <= fans; i++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A":  fansA++; break; 
                    case "B": fansB++;break;
                    case "V":fansV++;break;
                    case "G":fansG++;break;
                }
            }
                double convA = 1.0*fansA / fans * 100;
                double convB = 1.0*fansB / fans * 100;
                double convV = 1.0*fansV / fans * 100;
                double convG = 1.0*fansG / fans * 100;
                Console.WriteLine($"{convA:f2}%");
                Console.WriteLine($"{convB:f2}%");
                Console.WriteLine($"{convV:f2}%");
                Console.WriteLine($"{convG:f2}%");
                Console.WriteLine($"{1.0*fans/capacityStadium*100:f2}%");
        }
    }
}
