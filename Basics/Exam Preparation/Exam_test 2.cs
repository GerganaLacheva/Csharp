using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int foodAvailable= int.Parse(Console.ReadLine());
            double deer1FoodPerDay = double.Parse(Console.ReadLine());
            double deer2FoodPerDay = double.Parse(Console.ReadLine());
            double deer3FoodPerDay = double.Parse(Console.ReadLine());

            double foodNeeded = Math.Ceiling((deer1FoodPerDay + deer2FoodPerDay + deer3FoodPerDay) * numberOfDays);

            if (foodAvailable>=foodNeeded)
            {
                Console.WriteLine($"{(foodAvailable-foodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{(foodNeeded-foodAvailable)} more kilos of food are needed.");
            }

        }
    }
}
