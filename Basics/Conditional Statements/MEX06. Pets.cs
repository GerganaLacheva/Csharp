using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodAvailable = int.Parse(Console.ReadLine());
            double neededDogFood = double.Parse(Console.ReadLine()); //храна на ден за кучето в килограми 
            double neededCatFood = double.Parse(Console.ReadLine()); //храна на ден за котката в килограми
            double neededTurtleFoodGrams = double.Parse(Console.ReadLine()); //храна на ден за костенурката в грамове 

            double neededTurtleFood = neededTurtleFoodGrams / 1000;

            double foodNeeded = days * neededDogFood + days * neededCatFood + days * neededTurtleFood;

            if (foodAvailable>=foodNeeded)
            {
                Console.WriteLine($"{Math.Floor(foodAvailable-foodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded-foodAvailable)} more kilos of food are needed.");
            }
        }
    }
}
