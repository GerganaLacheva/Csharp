using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tae1.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double heratage = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            int age = 18;

            for (int currentYear = 1800; currentYear <= yearToLive; currentYear++)
            {
                if (currentYear%2==0)
                {
                    heratage -= 12000;
                }
                else
                {
                    heratage -= (12000 + 50 * age);
                }
                    age++;
            }
            if (heratage>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heratage:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(heratage):f2} dollars to survive.");
            }
        }
    }
}
