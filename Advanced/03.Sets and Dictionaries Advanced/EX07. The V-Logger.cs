using System;
using System.Collections.Generic;
using System.Linq;

namespace EX07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> data = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] tokens = input.Split();
                string vloggerName = tokens[0];
                string command = tokens[1];

                if (command == "joined")
                {
                    if (!data.ContainsKey(vloggerName))
                    {
                        data.Add(vloggerName, new Dictionary<string, SortedSet<string>>());
                        data[vloggerName].Add("followers", new SortedSet<string>());
                        data[vloggerName].Add("following", new SortedSet<string>());
                    }

                }
                else
                {
                    string vloggerName2 = tokens[2];
                    if (data.ContainsKey(vloggerName) && data.ContainsKey(vloggerName2) && !vloggerName.Equals(vloggerName2))
                    {
                        data[vloggerName]["following"].Add(vloggerName2);
                        data[vloggerName2]["followers"].Add(vloggerName);
                    }
                }
                input = Console.ReadLine();
            }
            data = PrintResults(data);
        }

        private static Dictionary<string, Dictionary<string, SortedSet<string>>> PrintResults(Dictionary<string, Dictionary<string, SortedSet<string>>> data)
        {
            Console.WriteLine($"The V-Logger has a total of {data.Keys.Count} vloggers in its logs.");


            data = data.OrderByDescending(x => x.Value["followers"].Count()).ThenBy(x => x.Value["following"].Count()).ToDictionary(x => x.Key, x => x.Value);

            var firstVlogger = data.Take(1);
            var app = data.TakeLast(data.Keys.Count - 1);
            foreach (var kvp in firstVlogger)
            {
                Console.WriteLine($"1. { kvp.Key} : { kvp.Value["followers"].Count} followers, {kvp.Value["following"].Count} following");
                foreach (var item in kvp.Value["followers"])
                {
                    Console.WriteLine($"*  {item}");
                }
            }
            int count = 2;
            foreach (var kvp in app)
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value["followers"].Count} followers, {kvp.Value["following"].Count} following");
                count++;
            }

            return data;
        }
    }
}
//The V-Logger
//Create a program that keeps the information about vloggers and their followers. The input will come as a sequence of strings, where each string will represent a valid command. The commands will be presented in the following format:
//•	"{vloggername}" joined The V-Logger – keep the vlogger in your records.
//o	Vloggernames consist of only one word.
//o	If the given vloggername already exists, ignore that command.

//•	"{vloggername} followed {vloggername}" – The first vlogger followed the second vlogger.
//o	If any of the given vlogernames does not exist in your collection, ignore that command.
//o	Vlogger cannot follow himself
//o	Vloggers cannot follow someone he is already a follower of

//•	"Statistics" - Upon receiving this command, you have to print a statistic about the vloggers.
//Each vlogger has a unique vloggername. Vloggers can follow other vloggers and a vlogger can follow as many other vloggers as he wants, but he cannot follow himself or follow someone he is already a follower of. You need to print the total count of vloggers in your collection. Then you have to print the most famous vlogger – the one with the most followers, with his followers. If more than one vloggers have the same number of followers, print the one following fewer people, and his followers should be printed in lexicographical order (in case the vlogger has no followers, print just the first line, which is described below). Lastly, print the rest vloggers, ordered by the count of followers in descending order, then by the number of vloggers he follows in ascending order. The whole output must be in the following format:
//"The V-Logger has a total of {registered vloggers} vloggers in its logs.
//1. { mostFamousVlogger} : { followers}
//followers, { followings}
//following
//*  { follower1}
//*  { follower2} … 
//{ No}. { vlogger} : { followers}
//followers, { followings}
//following
//{ No}. { vlogger} : { followers}
//followers, { followings}
//following…"
//Input
//•	The input will come in the format described above.
//Output
//•	On the first line, print the total count of vloggers in the format described above.
//•	On the second line, print the most famous vlogger in the format described above.
//•	On the next lines, print all of the rest vloggers in the format described above.
//Constraints
//•	There will be no invalid input.
//•	There will be no situation where two vloggers have an equal count of followers and equal count of followings
//•	Allowed time/memory: 100ms / 16MB.
//
//Examples
//Input	
//EmilConrad joined The V-Logger
//VenomTheDoctor joined The V-Logger
//Saffrona joined The V-Logger
//Saffrona followed EmilConrad
//Saffrona followed VenomTheDoctor
//EmilConrad followed VenomTheDoctor
//VenomTheDoctor followed VenomTheDoctor
//Saffrona followed EmilConrad
//Statistics	
//
//Output
//The V-Logger has a total of 3 vloggers in its logs.
//1. VenomTheDoctor : 2 followers, 0 following
//* EmilConrad
//*  Saffrona
//2. EmilConrad : 1 followers, 1 following
//3.Saffrona : 0 followers, 2 following
//
//Input
//JennaMarbles joined The V-Logger
//JennaMarbles followed Zoella
//AmazingPhil joined The V-Logger
//JennaMarbles followed AmazingPhil
//Zoella joined The V-Logger
//JennaMarbles followed Zoella
//Zoella followed AmazingPhil
//Christy followed Zoella
//Zoella followed Christy
//JacksGap joined The V-Logger
//JacksGap followed JennaMarbles
//PewDiePie joined The V-Logger
//Zoella joined The V-Logger
//Statistics	
//
//Output
//The V-Logger has a total of 5 vloggers in its logs.
//1. AmazingPhil : 2 followers, 0 following
//* JennaMarbles
//*  Zoella
//2. Zoella : 1 followers, 1 following
//3.JennaMarbles : 1 followers, 2 following
//4.PewDiePie : 0 followers, 0 following
//5.JacksGap : 0 followers, 1 following

