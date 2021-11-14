using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racers = Console.ReadLine()
                .Split(new string[] {", "},StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(x => x, x => 0);  //x=>x is key; x=>0 is value

            Regex nameRegex = new Regex(@"[A-Za-z]+");
            Regex digitsRegex = new Regex(@"\d");

            while (true)
            {
                string line = Console.ReadLine();

                if (line== "end of race")
                {
                    break;
                }

                MatchCollection letterMatches = nameRegex.Matches(line);
                MatchCollection digitsMatches = digitsRegex.Matches(line);

                string name = GetName(letterMatches);
                int sum = GetSum(digitsMatches);

                if (!racers.ContainsKey(name))
                {
                    continue;
                }
                racers[name] += sum;
            }
            string[] winners = racers.OrderByDescending(r => r.Value).Take(3).Select(r => r.Key).ToArray();

            Console.WriteLine($"1st place: {winners[0]}");
            Console.WriteLine($"2nd place: {winners[1]}");
            Console.WriteLine($"3rd place: {winners[2]}");

        }

        private static int GetSum(MatchCollection matchCollection)
        {
            int sum = 0;
            foreach (Match match in matchCollection)
            {
                sum += int.Parse(match.Value);
            }
            return sum;
        }

        private static string GetName(MatchCollection matches)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                sb.Append(match.Value);
            }
            return sb.ToString();
        }
    }
}
//2.Race
//Write a program that processes information about a race. On the first line you will be given list of participants separated by ", ". On the next few lines until you receive a line "end of race" you will be given some info which will be some alphanumeric characters. In between them you could have some extra characters which you should ignore. For example: "G!32e%o7r#32g$235@!2e".The letters are the name of the person and the sum of the digits is the distance he ran. So here we have George who ran 29 km. Store the information about the person only if the list of racers contains the name of the person. If you receive the same person more than once just add the distance to his old distance. At the end print the top 3 racers ordered by distance in descending in the format:
//"1st place: {first racer}
//2nd place: { second racer}
//3rd place: { third racer}
//"
//Examples
//Input		
//George, Peter, Bill, Tom
//G4e@55or%6g6!68e!!@
//R1@!3a$y4456@
//B5@i@#123ll
//G@e54o$r6ge#
//7P%et^#e5346r
//T$o553m&6
//end of race	

//Output
//1st place: George
//2nd place: Peter
//3rd place: Tom

//Input
//Ivan, Peter, James, Kyle
//I4v@43an%66?77!!@
//G1@!3u$s445s6@
//B3@i@#245ll
//I&v54a%66n@
//7P%et^#e5346r
//J$a553m&e6s
//K2y3=l/^e23
//end of race	

//Output
//1st place: Ivan
//2nd place: Peter
//3rd place: James
