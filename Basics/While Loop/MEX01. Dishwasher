using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tae01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            int detergentAvailable = bottles * 750;
            string input = Console.ReadLine();

            int counter = 1;
            int plates = 0;
            int pots = 0;
            int detergentConsumption = 0;
            int dishes = 0;

            while (detergentAvailable>=detergentConsumption)
            {
                if (input=="End")
                {
                    break;
                }
                dishes = int.Parse(input);

                if (counter % 3 == 0)
                {
                    detergentConsumption += dishes * 15;
                    pots += dishes;

                }
                else
                {
                    detergentConsumption += dishes * 5;
                    plates += dishes;
                }
                counter++;
                input = Console.ReadLine();
            }
            if (detergentAvailable >= detergentConsumption)
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{plates} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentAvailable - detergentConsumption} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {detergentConsumption - detergentAvailable} ml. more necessary!");
            }
        }
    }
}
