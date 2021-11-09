using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] commandArguments = input.Split('-');
                string user = commandArguments[0];

                if (commandArguments.Length > 2)            //{username}-{language}-{points}
                {
                    string language = commandArguments[1];
                    int points = int.Parse(commandArguments[2]);

                    if (!students.ContainsKey(user))
                    {
                        students.Add(user, points);
                    }
                    else
                    {
                        if (students[user] < points)    //проверяваме дали текущите точки са по-малко от точките
                        {
                            students[user] = points;    //и ако са по-малко -> взимаме по-големите точки
                        }
                    }
                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;

                }
                else                                        //{username}-banned
                {
                    students.Remove(user);
                }


                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");

            foreach (var student in students.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var submission in submissions.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
//10. * SoftUni Exam Results
//Judge statistics on the last Programing Fundamentals exam was not working correctly, so you have the task to take all the submissions and analyze them properly. You should collect all the submissions and print the final results and statistics about each language that the participants submitted their solutions in.
//You will be receiving lines in the following format: "{username}-{language}-{points}" until you receive "exam finished". You should store each username and his submissions and points. 
//You can receive a command to ban a user for cheating in the following format: "{username}-banned".In that case, you should remove the user from the contest, but preserve his submissions in the total count of submissions for each language.
//After receiving "exam finished" print each of the participants, ordered descending by their max points, then by username, in the following format:
//"Results:"
//"{username} | {points}"
//…
//After that print each language, used in the exam, ordered descending by total submission count and then by language name, in the following format:
//"Submissions:"
//"{language} – {submissionsCount}"
//…
//Input / Constraints
//Until you receive "exam finished" you will be receiving participant submissions in the following format: "{username}-{language}-{points}".
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
//Input	                Output	
//Peter-Java-84           Results:
//George - C#-70          Sam | 94
//George - C#-84          George | 84
//Sam - C#-94             Peter | 84
//exam finished	        Submissions:
//                        C# - 3
//                        Java -1
//Comment
//We order the participant descending by max points and then by name, printing only the username and the max points.
//After that, we print each language along with the count of submissions, ordered descending by submissions count, and then by language name.

//Input	                Output	
//Peter-Java-91           Results:
//George - C#-84          Peter | 91
//Sam -JavaScript-90      George | 84
//Sam - C#-50             Submissions:
//Sam -banned             C# - 2
//exam finished           Java -1
//	                    JavaScript - 1

//Comment
//Sam is banned so he is removed from the contest, but his submissions are still preserved in the languages submissions count. 
//So although there are only 2 participants in the results, there are 4 submissions in total.
