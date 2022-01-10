using System;
using System.Collections.Generic;
using System.Linq;

namespace EX09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userPoints = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();
            var userData =
                  new Dictionary<string, Dictionary<string, double>>();

            var input = Console.ReadLine();
            while (input != "exam finished")
            {
                var inputArgs = input.Split("-");

                var user = inputArgs[0];
                var languageOrBan = inputArgs[1];
                if (languageOrBan == "banned")
                {
                    userPoints.Remove(user);
                    input = Console.ReadLine();
                    continue;
                }
                var points = int.Parse(inputArgs[2]);
                if (!userPoints.ContainsKey(user))
                {
                    userPoints[user] = 0;
                }
                userPoints[user] = Math.Max(userPoints[user], points);
                if (!submissions.ContainsKey(languageOrBan))
                {
                    submissions[languageOrBan] = 0;
                }
                submissions[languageOrBan] += 1;
                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var kvp in userPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value);
            }
            Console.WriteLine("Submissions:");
            foreach (var kvp in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
            }
        }
    }
}
//SoftUni Exam Results
//Judge statistics on the last Programing Fundamentals exam was not working correctly, so you have the task to take all the submissions and analyze them properly. You should collect all the submissions and print the final results and statistics about each language that the participants submitted their solutions in.
//You will be receiving lines in the following format: "{username}-{language}-{points}" until you receive "exam finished". You should store each username and his submissions and points. 
//You can receive a command to ban a user for cheating in the following format: "{username}-banned".In that case, you should remove the user from the contest, but preserve his submissions in the total count of submissions for each language.
//After receiving "exam finished" print each of the participants, ordered descending by their max points, then by username, in the following format:
//"Results:"
//"{username} | {points}"
//…
//After that print each language, used in the exam, ordered descending by total submission count and then by language name,
//in the following format:
//"Submissions:"
//"{language} – {submissionsCount}"
//…
//Input / Constraints
//Until you receive "exam finished" you will be receiving participant submissions in the following format:
//"{username}-{language}-{points}".
//You can receive a ban command -> "{username}-banned"
//The points of the participant will always be a valid integer in the range [0-100];
//Output
//•	Print the exam results for each participant, ordered descending by max points and then by username, in the following format: 
//"Results:"
//"{username} | {points}"
//…
//•	After that print each language, ordered descending by total submissions and then by language name, in the following format:
//"Submissions:"
//"{language} – {submissionsCount}"
//…
//•	Allowed working time / memory: 100ms / 16MB.
//Examples
//Input		
//Peter-Java-84
//George-C#-70
//George-C#-84
//Sam-C#-94
//exam finished	
//
//Output
//Results:
//Sam | 94
//George | 84
//Peter | 84
//Submissions:
//C# - 3
//Java -1
//
//Comment
//We order the participant descending by max points and then by name, printing only the username and the max points.
//After that, we print each language along with the count of submissions, ordered descending by submissions count,
//and then by language name.

//Input
//Peter - Java - 91
//George - C#-84
//Sam - JavaScript - 90
//Sam - C#-50
//Sam - banned
//exam finished
	
//Output
//Results:
//Peter | 91
//George | 84
//Submissions:
//C# - 2
//Java -1
//JavaScript - 1

//Comment
//Sam is banned so he is removed from the contest, but his submissions are still preserved in the languages submissions count. 
//So although there are only 2 participants in the results, there are 4 submissions in total.

