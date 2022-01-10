using System;
using System.Collections.Generic;
using System.Linq;

namespace EX06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split(" -> ");
                string color = inputArgs[0];
                string[] clothes = inputArgs[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                foreach (var item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }
                    wardrobe[color][item]++;
                }
            }
            string[] targetClothe = Console.ReadLine().Split();
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var (clothe, value) in color.Value)
                {
                    if (clothe == targetClothe[1] && color.Key == targetClothe[0])
                    {
                        Console.WriteLine($"* {clothe} - {value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothe} - {value}");
                    }
                }
            }
        }
    }
}
//Problem 6.Wardrobe
//Create a program that helps you decide what clothes to wear from your wardrobe. You will receive the clothes, which are currently in your wardrobe, sorted by their color in the following format:
//"{color} -> {item1},{item2},{item3}…"
//If you receive a certain color, which already exists in your wardrobe, just add the clothes to its records. You can also receive repeating items for a certain color and you have to keep their count.
//In the end, you will receive a color and a piece of clothing, which you will look for in the wardrobe, separated by a space in the following format:
//"{color} {clothing}"
//Your task is to print all the items and their count for each color in the following format: 
//"{color} clothes:
//* { item1}
//- { count}
//* { item2}
//- { count}
//* { item3}
//- { count}
//…
//* { itemN}
//- { count}
//"
//If you find the item you are looking for, you need to print "(found!)" next to it:
//"* {itemN} - {count} (found!)"
//Input
//•	On the first line, you will receive n - the number of lines of clothes, which you will receive.
//•	On the next n lines, you will receive the clothes in the format described above.
//Output
//•	Print the clothes from your wardrobe in the format described above 
//Examples
//Input	
//4
//Blue -> dress, jeans, hat
//Gold -> dress, t-shirt, boxers
//White -> briefs, tanktop
//Blue -> gloves
//Blue dress	
//
//Output
//Blue clothes:
//*dress - 1(found!)
//* jeans - 1
//* hat - 1
//* gloves - 1
//Gold clothes:
//*dress - 1
//* t - shirt - 1
//* boxers - 1
//White clothes:
//*briefs - 1
//* tanktop - 1
//
//Input
//4
//Red->hat
//Red->dress,t - shirt,boxers
//White -> briefs, tanktop
//Blue -> gloves
//White tanktop	
//
//Output
//Red clothes:
//*hat - 1
//* dress - 1
//* t - shirt - 1
//* boxers - 1
//White clothes:
//*briefs - 1
//* tanktop - 1(found!)
//Blue clothes:
//*gloves - 1
//
//Input
//5
//Blue->shoes
//Blue->shoes,shoes,shoes
//Blue -> shoes, shoes
//Blue -> shoes
//Blue -> shoes, shoes
//Red tanktop	
//
//Output
//Blue clothes:
//*shoes - 9
