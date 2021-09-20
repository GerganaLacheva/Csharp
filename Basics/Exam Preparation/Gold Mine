using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int location = int.Parse(Console.ReadLine());

            for (int i = 0; i < location; i++)
            {
                double expectedExtraction = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                double totalExtraction = 0;

                for (int j = 0; j < days; j++)
                {
                    double extraction = double.Parse(Console.ReadLine());
                    totalExtraction += extraction;
                }

                double totalGold = totalExtraction / days;

                if (totalGold >= expectedExtraction)
                {
                    Console.WriteLine($"Good job! Average gold per day: {totalGold:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {expectedExtraction - totalGold:f2} gold.");
                }
            }
        }
    }
}
