using System;
using System.Collections.Generic;
using System.Linq;

namespace EP03.Nikuldens_Meals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> userMeals =new Dictionary<string, List<string>>();

            string input=Console.ReadLine();
            int totalUnlikedMeals = 0;

            while (input!="Stop")
            {
                string[] inputInfo=input.Split("-");

                string action=inputInfo[0];
                string name=inputInfo[1];
                string meal=inputInfo[2];

                if (action=="Like")
                {
                    if (!userMeals.ContainsKey(name))
                    {
                        userMeals.Add(name, new List<string>());
                    }
                    if (!userMeals[name].Contains(meal))
                    {
                        userMeals[name].Add(meal);
                    }

                }
                else if (action=="Unlike")
                {
                    if (!userMeals.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} is not at the party.");
                    }
                    else if (!userMeals[name].Contains(meal))
                    {
                        Console.WriteLine($"{name} doesn't have the {meal} in his/her collection");
                    }
                    else
                    {
                        userMeals[name].Remove(meal);
                        Console.WriteLine($"{name} doesn't like the {meal}.");
                        totalUnlikedMeals++;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var (name, meals) in userMeals.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{name}: {string.Join(", ",meals)}");
            }
            Console.WriteLine($"Unliked meals: {totalUnlikedMeals}");
        }
    }
}
//Input

//Like-Krisi-shrimps
//Like-Krisi-soup
//Like-Misho-salad
//Like-Pena-dessert
//Stop

//Output

//Krisi: shrimps, soup
//Misho: salad
//Pena: dessert
//Unliked meals: 0

//Input

//Like-Krisi-shrimps
//Unlike-Vili-carp
//Unlike-Krisi-salad
//Unlike-Krisi-shrimps
//Stop

//Output

//Vili is not at the party.
//Krisi doesn't have the salad in his/her collection.
//Krisi doesn't like the shrimps.
//Krisi:
//Unliked meals: 1
