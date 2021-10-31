using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05.TeamworkProjects_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] teamData = Console.ReadLine()
                    .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                string creator = teamData[0];
                string teamName = teamData[1];

                bool existingTeam = teams
                    .Select(x => x.TeamName).Contains(teamName);

                bool existingCreator = teams
                    .Any(x => x.CreatorName == creator);


                if (existingTeam == false && existingCreator == false)
                {
                    Team currentTeam = new Team(teamName, creator);

                    teams.Add(currentTeam);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
                else if (existingTeam)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (existingCreator)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
            } 

            while (true)
            {
                string teamMembers = Console.ReadLine();

                if (teamMembers == "end of assignment")
                {
                    break;
                }

                string[] input = teamMembers
                    .Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string user = input[0];

                string teamName = input[1];

                bool existingTeam = teams.Any(x => x.TeamName == teamName);

                bool existingCreator = teams.Any(x => x.CreatorName == user);
                bool existingMember = teams.Any(x => x.Members.Contains(user));

                if (existingTeam && existingCreator == false && existingMember == false)
                {
                    int indexOfTeam = teams
                        .FindIndex(x => x.TeamName == teamName);

                    teams[indexOfTeam].Members.Add(user);
                }
                else if (existingTeam == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (existingMember || existingCreator)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
            } 

            List<Team> validTeam = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();

            List<Team> notValidTeam = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            foreach (var team in validTeam)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine("- " + team.CreatorName);
                team.Members.Sort();
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => "-- " + x)));
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in notValidTeam)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
    public class Team
    {
        public Team(string name, string creatorName)
        {
            TeamName = name;

            CreatorName = creatorName;

            Members = new List<string>();

        }

        public string TeamName { get; set; }

        public string CreatorName { get; set; }

        public List<string> Members { get; set; }
    }
}
//5.Teamwork Projects
//It's time for the teamwork projects and you are responsible for gathering the teams. First, you will receive an integer - the count of the teams you will have to register. You will be given a user and a team, separated with “-”.  The user is the creator of the team. For every newly created team you should print a message: 
//"Team {teamName} has been created by {user}!".
//Next, you will receive а user with a team, separated with "->", which means that the user wants to join that team. Upon receiving the command: “end of assignment”, you should print every team, ordered by the count of its members (descending) and then by name (ascending). For each team, you have to print its members sorted by name (ascending). However, there are several rules:
//•	If а user tries to create a team more than once, a message should be displayed: 
//-"Team {teamName} was already created!"
//•	A creator of a team cannot create another team – the following message should be thrown: 
//-"{user} cannot create another team!"
//•	If а user tries to join a non-existent team, a message should be displayed: 
//-"Team {teamName} does not exist!"
//•	A member of a team cannot join another team – the following message should be thrown:
//-"Member {user} cannot join team {team Name}!"
//•	In the end, teams with zero members (with only a creator) should disband and you have to print them ordered by name in ascending order. 
//•	 Every valid team should be printed ordered by name (ascending) in the following format:
//"{teamName}
//- { creator}
//-- { member}…"
//Examples
//Input	Output	Comments
//2
//John-PowerPuffsCoders
//Tony-Tony is the best
//Peter->PowerPuffsCoders
//Tony->Tony is the best
//end of assignment	Team PowerPuffsCoders has been created by John!
//Team Tony is the best has been created by Tony!
//Member Tony cannot join team Tony is the best!
//PowerPuffsCoders
//- John
//-- Peter
//Teams to disband:
//Tony is the best    Tony created a team, which he attempted to join later and this action resulted in throwing a certain message. Since nobody else tried to join his team, the team had to disband.
//3
//Tanya-CloneClub
//Helena-CloneClub
//Tedy-SoftUni
//George->softUni
//George->SoftUni
//Tatyana->Leda
//John->SoftUni
//Cossima->CloneClub
//end of assignment	Team CloneClub has been created by Tanya!
//Team CloneClub was already created!
//Team SoftUni has been created by Tedy!
//Team softUni does not exist!
//Team Leda does not exist!
//SoftUni
//- Tedy
//-- George
//-- John
//CloneClub
//- Tanya
//-- Cossima
//Teams to disband:	Note that when a user joins a team, you should first check if the team exists and then check if the user is already in a team:

//Tanya has created CloneClub, then she tried to join a non-existent team and the concrete message was displayed.
