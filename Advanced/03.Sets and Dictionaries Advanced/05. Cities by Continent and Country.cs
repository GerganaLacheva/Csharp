using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens=Console.ReadLine().Split().ToArray();

                if (!continents.ContainsKey(tokens[0]))
                {
                    continents.Add(tokens[0], new Dictionary<string,List<string>>());
                }
                if (!continents[tokens[0]].ContainsKey(tokens[1]))
                {
                    continents[tokens[0]].Add(tokens[1], new List<string>());
                }
                continents[tokens[0]][tokens[1]].Add(tokens[2]);
            }

            foreach (var item in continents)
            {
                Console.WriteLine(item.Key + ":");
                foreach (var country in item.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
//5.Cities by Continent and Country
//Create a program that reads continents, countries, and their cities put them in a nested dictionary and prints them.
//Examples
//Input	
//9
//Europe Bulgaria Sofia
//Asia China Beijing
//Asia Japan Tokyo
//Europe Poland Warsaw
//Europe Germany Berlin
//Europe Poland Poznan
//Europe Bulgaria Plovdiv
//Africa Nigeria Abuja
//Asia China Shanghai	
//
//Output
//Europe:
//  Bulgaria->Sofia, Plovdiv
//  Poland -> Warsaw, Poznan
//  Germany -> Berlin
//Asia:
//  China->Beijing, Shanghai
//  Japan -> Tokyo
//Africa:
//  Nigeria->Abuja
