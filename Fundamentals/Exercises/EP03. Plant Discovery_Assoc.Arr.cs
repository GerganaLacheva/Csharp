using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> plants = new Dictionary<string, List<int>>();
            Dictionary<string, List<double>> plantsWithAverageRating = new Dictionary<string, List<double>>();

            for (int i = 1; i <= n; i++)
            {
                string[] plantsInfo = Console.ReadLine().Split("<->");
                string currentPlant = plantsInfo[0];
                int currentPlantRarity = int.Parse(plantsInfo[1]);
                if (!plants.ContainsKey(currentPlant))
                {
                    plants.Add(currentPlant, new List<int>());
                    plants[currentPlant].Add(currentPlantRarity);
                    plants[currentPlant].Add(0);
                    plants[currentPlant].Add(0);
                }
                else
                {
                    plants[currentPlant][0] = currentPlantRarity;
                }

            }
            string command = Console.ReadLine();
            while (command != "Exhibition")
            {
                string[] actions = command.Split();
                string currentAction = actions[0];
                if (currentAction == "Rate:")
                {
                    string currentPlant = actions[1];
                    if (plants.ContainsKey(currentPlant))
                    {
                        int currentRating = int.Parse(actions[3]);
                        plants[currentPlant][1] += currentRating;
                        plants[currentPlant][2]++;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (currentAction == "Update:")
                {
                    string currentPlant = actions[1];
                    if (plants.ContainsKey(currentPlant))
                    {
                        int newRarity = int.Parse(actions[3]);
                        plants[currentPlant][0] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (currentAction == "Reset:")
                {
                    string currentPlant = actions[1];
                    if (plants.ContainsKey(currentPlant))
                    {
                        plants[currentPlant][1] = 0;
                        plants[currentPlant][2] = 0;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var plant in plants)
            {
                string newPlant = plant.Key;
                double newPlantRarity = plant.Value[0];
                double averagePlantRating = 0.00;

                if (plant.Value[2] != 0)
                {
                    averagePlantRating = plant.Value[1] * 1.00 / plant.Value[2];
                }

                plantsWithAverageRating.Add(newPlant, new List<double>());
                plantsWithAverageRating[newPlant].Add(newPlantRarity);
                plantsWithAverageRating[newPlant].Add(averagePlantRating);
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var newPlant in plantsWithAverageRating.OrderByDescending(x => x.Value[0]).ThenByDescending(y => y.Value[1]))
            {
                Console.WriteLine($"- {newPlant.Key}; Rarity: {newPlant.Value[0]}; Rating: {newPlant.Value[1]:f2}");
            }
        }
    }
}
//Problem 3 - Plant Discovery
//Problem for exam preparation for the Programming Fundamentals Course @SoftUni.
//Submit your solutions in the SoftUni judge system at https://judge.softuni.org/Contests/Practice/Index/2518#2.

//You have now returned from your world tour. On your way, you have discovered some new plants, and you want to gather some information about them and create an exhibition to see which plant is highest rated.
//On the first line, you will receive a number n. On the next n lines, you will be given some information about the plants that you have discovered in the format: "{plant}<->{rarity}".Store that information because you will need it later. If you receive a plant more than once, update its rarity.
//After that, until you receive the command "Exhibition", you will be given some of these commands:
//•	"Rate: {plant} - {rating}" – add the given rating to the plant (store all ratings)
//•	"Update: {plant} - {new_rarity}" – update the rarity of the plant with the new one
//•	"Reset: {plant}" – remove all the ratings of the given plant
//Note: If any given plant name is invalid, print "error"
//After the command "Exhibition", print the information that you have about the plants in the following format:
//"Plants for the exhibition:
//- { plant_name1}; Rarity: { rarity}; Rating: { average_rating}
//- { plant_name2}; Rarity: { rarity}; Rating: { average_rating}
//…
//- { plant_nameN}; Rarity: { rarity}; Rating: { average_rating}
//"
//The plants should be sorted by rarity in descending order. If two or more plants have the same rarity value sort them by average rating in descending order. The average rating should be formatted to the second decimal place.
//Input / Constraints
//•	You will receive the input as described above
//•	JavaScript: you will receive a list of strings
//Output
//•	Print the information about all plants as described above
//
//Examples
//Input	
//3
//Arnoldii<->4
//Woodii<->7
//Welwitschia<->2
//Rate: Woodii - 10
//Rate: Welwitschia - 7
//Rate: Arnoldii - 3
//Rate: Woodii - 5
//Update: Woodii - 5
//Reset: Arnoldii
//Exhibition
//
//Output
//Plants for the exhibition:
//-Woodii; Rarity: 5; Rating: 7.50
//- Arnoldii; Rarity: 4; Rating: 0.00
//- Welwitschia; Rarity: 2; Rating: 7.00
//
//Input
//2
//Candelabra <->10
//Oahu <->10
//Rate: Oahu - 7
//Rate: Candelabra - 6
//Exhibition
//
//Output
//Plants for the exhibition:
//-Oahu; Rarity: 10; Rating: 7.00
//- Candelabra; Rarity: 10; Rating: 6.00
