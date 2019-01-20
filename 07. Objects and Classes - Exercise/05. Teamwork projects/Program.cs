namespace _05._Teamwork_projects
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Teams
    {
        public Teams(string teamName, string creatorName)
        {
            TeamName = teamName;
            CreatorName = creatorName;
            Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
    class Program
    {
        public static void Main()
        {
            List<Teams> list = new List<Teams>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                string teamName = input[1];
                string creatorName = input[0];

                bool haveThisTeamName = list.Any(x => x.TeamName == teamName);
                bool haveThisCreatorName = list.Any(x => x.CreatorName == creatorName);

                if (haveThisTeamName)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (haveThisCreatorName)
                {
                    Console.WriteLine($"{teamName} cannot create another team!");
                }
                else
                {
                    Teams currentTeam = new Teams(teamName, creatorName);
                    list.Add(currentTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of assignment")
                {
                    break;
                }
                string[] input = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string teamName = input[1];
                string user = input[0];

                bool haveThisTeamName = list.Any(x => x.TeamName == teamName);
                bool haveThisUserName = list.Any(x => x.Members.Contains(user) || x.CreatorName == user);


                if (!haveThisTeamName)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (haveThisUserName)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    int indexThisTeamName = list.FindIndex(x => x.TeamName == teamName);
                    list[indexThisTeamName].Members.Add(user);
                }
            }

            List<Teams> teamsWhitUsers = list.Where(x => x.Members.Count > 0).ToList();
            List<Teams> teamsWhitZeroUsers = list.Where(x => x.Members.Count == 0).ToList();

            foreach (var team in teamsWhitUsers.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.CreatorName}");
                foreach (var user in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {user}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var item in teamsWhitZeroUsers.OrderBy(x => x.TeamName))
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }
}
