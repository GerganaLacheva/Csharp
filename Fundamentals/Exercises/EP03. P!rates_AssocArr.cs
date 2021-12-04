using System;
using System.Collections.Generic;
using System.Linq;

namespace EP03._P_rates_Dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> target = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string[] inputTokens = input.Split("||");

                string town = inputTokens[0];
                int people = int.Parse(inputTokens[1]);
                int gold = int.Parse(inputTokens[2]);

                if (!target.ContainsKey(town))
                {
                    target.Add(town, new List<int> { people, gold });
                }
                else
                {
                    List<int> currentValues = target[town];
                    currentValues[0] += people;
                    currentValues[1] += gold;
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputTokens = input.Split("=>");

                string action = inputTokens[0];

                if (action == "Plunder")
                {
                    string town = inputTokens[1];
                    int people = int.Parse(inputTokens[2]);
                    int gold = int.Parse(inputTokens[3]);

                    List<int> currentValues = target[town];
                    currentValues[0] -= people;
                    currentValues[1] -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (currentValues[0] <= 0 || currentValues[1] <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        target.Remove(town);
                    }
                }
                else if (action == "Prosper")
                {
                    string town = inputTokens[1];
                    int gold = int.Parse(inputTokens[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        input = Console.ReadLine();
                        continue;
                    }
                    List<int> currentValues = target[town];       
                    currentValues[1] += gold;

                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {currentValues[1]} gold.");

                }

                input = Console.ReadLine();
            }

            if (target.Count == 0)
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {target.Count} wealthy settlements to go to:");

                foreach (var item in target.OrderByDescending(x=>x.Value[1]).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
        }
    }
}
//Problem 3 - P!rates
//Problem for exam preparation for the Programming Fundamentals Course @SoftUni.
//Submit your solutions in the SoftUni judge system at https://judge.softuni.org/Contests/Practice/Index/2302#2.

//Anno 1681.The Caribbean.The golden age of piracy. You are a well-known pirate captain by the name of Jack Daniels. Together with your comrades Jim (Beam) and Johnny(Walker), you have been roaming the seas, looking for gold and treasure… and the occasional killing, of course. Go ahead, target some wealthy settlements and show them the pirate's way!
//Until the "Sail" command is given, you will be receiving:
//•	You and your crew have targeted cities, with their population and gold, separated by "||".
//•	If you receive a city that has already been received, you have to increase the population and gold with the given values.
//After the "Sail" command, you will start receiving lines of text representing events until the "End" command is given. 
//Events will be in the following format:
//•	"Plunder=>{town}=>{people}=>{gold}"
//o You have successfully attacked and plundered the town, killing the given number of people and stealing the respective amount of gold. 
//o	For every town you attack print this message: "{town} plundered! {gold} gold stolen, {people} citizens killed."
//o If any of those two values (population or gold) reaches zero, the town is disbanded.
//	You need to remove it from your collection of targeted cities and print the following message: "{town} has been wiped off the map!"
//o There will be no case of receiving more people or gold than there is in the city.
//•	"Prosper=>{town}=>{gold}"
//o	There has been dramatic economic growth in the given city, increasing its treasury by the given amount of gold.
//o	The gold amount can be a negative number, so be careful. If a negative amount of gold is given, print: "Gold added cannot be a negative number!" and ignore the command.
//o	If the given gold is a valid amount, increase the town's gold reserves by the respective amount and print the following message: 
//"{gold added} gold added to the city treasury. {town} now has {total gold} gold."
//Input
//•	On the first lines, until the "Sail" command, you will be receiving strings representing the cities with their gold and population, separated by "||"
//•	On the following lines, until the "End" command, you will be receiving strings representing the actions described above, separated by "=>"
//Output
//•	After receiving the "End" command, if there are any existing settlements on your list of targets, you need to print all of them, sorted by their gold in descending order, then by their name in ascending order, in the following format:
//"Ahoy, Captain! There are {count} wealthy settlements to go to:
//{ town1} -> Population: { people}
//citizens, Gold: { gold}
//kg
//{ town2} -> Population: { people}
//citizens, Gold: { gold}
//kg
//   …
//{ town…n} -> Population: { people}
//citizens, Gold: { gold}
//kg "
//•	If there are no settlements left to plunder, print:
//"Ahoy, Captain! All targets have been plundered and destroyed!"
//Constraints
//•	The initial population and gold of the settlements will be valid 32-bit integers, never negative, or exceed the respective limits.
//•	The town names in the events will always be valid towns that should be on your list.
//
//Examples
//Input	
//Tortuga||345000||1250
//Santo Domingo||240000||630
//Havana||410000||1100
//Sail
//Plunder=>Tortuga=>75000=>380
//Prosper=>Santo Domingo=>180
//End	
//
//Output
//Tortuga plundered! 380 gold stolen, 75000 citizens killed.
//180 gold added to the city treasury. Santo Domingo now has 810 gold.
//Ahoy, Captain! There are 3 wealthy settlements to go to:
//Havana->Population: 410000 citizens, Gold: 1100 kg
//Tortuga -> Population: 270000 citizens, Gold: 870 kg
//Santo Domingo -> Population: 240000 citizens, Gold: 810 kg
//
//Input	
//Nassau||95000||1000
//San Juan||930000||1250
//Campeche||270000||690
//Port Royal||320000||1000
//Port Royal||100000||2000
//Sail
//Prosper=>Port Royal=>-200
//Plunder=>Nassau=>94000=>750
//Plunder=>Nassau=>1000=>150
//Plunder=>Campeche=>150000=>690
//End	
//
//Output
//Gold added cannot be a negative number!
//Nassau plundered! 750 gold stolen, 94000 citizens killed.
//Nassau plundered! 150 gold stolen, 1000 citizens killed.
//Nassau has been wiped off the map!
//Campeche plundered! 690 gold stolen, 150000 citizens killed.
//Campeche has been wiped off the map!
//Ahoy, Captain! There are 2 wealthy settlements to go to:
//Port Royal -> Population: 420000 citizens, Gold: 3000 kg
//San Juan -> Population: 930000 citizens, Gold: 1250 kg
