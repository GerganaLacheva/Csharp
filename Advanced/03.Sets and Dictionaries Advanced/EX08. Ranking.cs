using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsPass = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "end of contests")
            {
                string[] arguments = input.Split(":");
                string contestName = arguments[0];
                string pass = arguments[1];
                contestsPass.Add(contestName, pass);
                input = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();
            string input2 = Console.ReadLine();
            while (input2 != "end of submissions")
            {
                string[] inputArgs = input2.Split("=>");
                string contest = inputArgs[0];
                string password = inputArgs[1];
                string username = inputArgs[2];
                int points = int.Parse(inputArgs[3]);

                if (contestsPass.ContainsKey(contest) && contestsPass[contest] == password)
                {
                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, new Dictionary<string, int>());
                        students[username].Add(contest, points);
                    }
                    else
                    {
                        if (!students[username].ContainsKey(contest))
                        {
                            students[username].Add(contest, points);
                        }
                        else if (students[username][contest] < points)
                        {
                            students[username][contest] = points;
                        }
                    }
                }
                input2 = Console.ReadLine();
            }

            students = PrintResults(students);
        }

        private static Dictionary<string, Dictionary<string, int>> PrintResults(Dictionary<string, Dictionary<string, int>> students)
        {
            var bestStudents = students.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(x => x.Key, x => x.Value);
            var bestPointsStudent = bestStudents.Take(1);
            foreach (var item in bestPointsStudent)
            {
                Console.WriteLine($"Best candidate is {item.Key} with total {item.Value.Values.Sum()} points.");
            }
            Console.WriteLine("Ranking:");
            students = students.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var (key, value) in students)
            {
                Console.WriteLine($"{key}");
                foreach (var item in value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }

            return students;
        }
    }
}
//Ranking
//Create a program that ranks candidate-interns, depending on the points from the interview tasks and their exam results in SoftUni. You will receive some lines of input in the format "{contest}:{password for contest}" until you receive "end of contests". Save that data because you will need it later. After that you will receive another type of inputs in the format "{contest}=>{password}=>{username}=>{points}" until you receive "end of submissions". Here is what you need to do:
//•	Check if the contest is valid(if you received it in the first type of input)
//•	Check if the password is correct for the given contest
//•	Save the user with the contest they take part in (a user can take part in many contests) and the points the user has in the given contest. If you receive the same contest and the same user, update the points only if the new ones are more than the older ones.
//At the end you have to print the info for the user with the most points in the format:
//"Best candidate is {user} with total {total points} points.".After that print all students ordered by their names. For each user, print each contest with the points in descending order in the following format:
//"{user1 name}
//#  {contest1} -> {points}
//#  {contest2} -> {points}
//{ user2 name}
//…"
//Input
//•	You will be receiving strings in the formats described above, until the appropriate commands, also described above, are given.
//Output
//•	On the first line print, the best user in the format described above. 
//•	On the next lines print all students ordered as mentioned above in format.
//Constraints
//•	There will be no case with two equal contests.
//•	The strings may contain any ASCII character except (:, =, >).
//•	The numbers will be in the range [0 - 10000].
//•	The second input is always valid.
//•	There will be no case with 2 or more users with the same total points.
//
//Examples
//Input	
//Part One Interview:success
//Js Fundamentals:JSFundPass
//C# Fundamentals:fundPass
//Algorithms:fun
//end of contests
//C# Fundamentals=>fundPass=>Tanya=>350
//Algorithms=>fun=>Tanya=>380
//Part One Interview=>success=>Nikola=>120
//Java Basics Exam=>JSFundPass=>Parker=>400
//Part One Interview=>success=>Tanya=>220
//OOP Advanced=>password123=>BaiIvan=>231
//C# Fundamentals=>fundPass=>Tanya=>250
//C# Fundamentals=>fundPass=>Nikola=>200
//Js Fundamentals=>JSFundPass=>Tanya=>400
//end of submissions	
//
//Output
//Best candidate is Tanya with total 1350 points.
//Ranking:
//Nikola
//#  C# Fundamentals -> 200
//#  Part One Interview -> 120
//Tanya
//#  Js Fundamentals -> 400
//#  Algorithms -> 380
//#  C# Fundamentals -> 350
//#  Part One Interview -> 220
//
//Input
//Java Advanced:funpass
//Part Two Interview:success
//Math Concept:asdasd
//Java Web Basics:forrF
//end of contests
//Math Concept=>ispass=>Monika=>290
//Java Advanced=>funpass=>Simon=>400
//Part Two Interview=>success=>Drago=>120
//Java Advanced=>funpass=>Petyr=>90
//Java Web Basics=>forrF=>Simon=>280
//Part Two Interview=>success=>Petyr=>0
//Math Concept=>asdasd=>Drago=>250
//Part Two Interview=>success=>Simon=>200
//end of submissions

//Output
//Best candidate is Simon with total 880 points.
//Ranking: 
//Drago
//#  Math Concept -> 250
//#  Part Two Interview -> 120
//Petyr
//#  Java Advanced -> 90
//#  Part Two Interview -> 0
//Simon
//#  Java Advanced -> 400
//#  Java Web Basics -> 280
//#  Part Two Interview -> 200


