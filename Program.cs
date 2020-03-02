using System;
using System.Collections.Generic;

namespace heist
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Dictionary<string, string>> entireTeam = new List<Dictionary<string, string>>();

      int count = 0;
      int bankDifficulty = 100;
      int total = 0;
      int teamSkillLevelCombined = 0;

      Console.WriteLine("Time to plan a heist...");

      while (true)
      {

        Dictionary<string, string> teamInfo = new Dictionary<string, string>();

        string teamMemberName = "";

        Console.WriteLine("Enter team member name...");
        teamMemberName = Console.ReadLine();
        teamInfo.Add("Name:", teamMemberName);


        if (teamMemberName == "")
        {
          if (total < bankDifficulty)
          {
            Console.WriteLine("Get a day job");
          }
          else
          {
            Console.WriteLine("Lets rob a bank");
          };
          if (count == 1)
          {

            Console.WriteLine($"You have {count} member on your team");
          }
          else
          {
            Console.WriteLine($"You have {count} members on your team");

          }

          foreach (Dictionary<string, string> team in entireTeam)
          {
            foreach (KeyValuePair<string, string> info in team)
            {
              Console.WriteLine($"Team member's {info.Key} {info.Value}");
            }
          }
          break;
        }


        Console.WriteLine("Enter team member skill level...(1 - 50)");
        string skillLevel = Console.ReadLine();
        int skillLevelInt = int.Parse(skillLevel);
        teamInfo.Add("Skill level:", skillLevel);
        Console.WriteLine("Enter courage factor in decimals...(0.0 - 2.0)");
        teamInfo.Add("Courage factor:", Console.ReadLine());

        total = teamSkillLevelCombined += skillLevelInt;


        entireTeam.Add(teamInfo);
        count++;


      }

    }






  }
}
