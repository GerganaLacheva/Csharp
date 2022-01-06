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
                string[] tokens = Console.ReadLine().Split().ToArray();
           
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }

                continents[continent][country].Add(city);

            }

            foreach (var continent in continents)
            {
                Console.WriteLine(continent.Key + ":");
                foreach (var country in continent.Value)
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

