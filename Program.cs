using System;
using System.Collections.Generic;

namespace heist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Lets plan a heist!");

      Console.Write("What is the bank's dificulty level? ");
      int bankDifficulty = int.Parse(Console.ReadLine());

      List<Dictionary<string, string>> entireTeam = new List<Dictionary<string, string>>();

      int totalTeamSkillLevel = 0;
      int successfulRuns = 0;
      int unsuccessfulRuns = 0;

      while (true)
      {
        Dictionary<string, string> teamMember = new Dictionary<string, string>();

        Console.Write("Enter team member's name: ");
        string singleMemberName = Console.ReadLine();

        if (singleMemberName == "")
        {
          Console.Clear();

          if (entireTeam.Count == 1)
          {

            Console.WriteLine($"You have {entireTeam.Count} member in your crew!");
          }
          else
          {

            Console.WriteLine($"You have a crew of {entireTeam.Count} members!");
          }



          Console.Write("How many times are we running the heist? ");
          int heistRuns = int.Parse(Console.ReadLine());

          foreach (Dictionary<string, string> member in entireTeam)
          {
            foreach (KeyValuePair<string, string> memberInfo in member)
            {
              if (memberInfo.Key == "skillLevel")
              {
                totalTeamSkillLevel += int.Parse(memberInfo.Value);
              }
            }
          }

          Console.WriteLine($"The team has a combined skill level of { totalTeamSkillLevel}.");

          for (int i = 0; i < heistRuns; i++)
          {
            Random bankLuckValue = new Random();
            int temporaryBankDifficuly = bankDifficulty;
            int bankLuckValueInt = bankLuckValue.Next(-10, 11);
            temporaryBankDifficuly += bankLuckValueInt;

            if (totalTeamSkillLevel >= temporaryBankDifficuly)
            {
              Console.WriteLine($"The bank's difficuly level is {temporaryBankDifficuly}.");
              Console.WriteLine("💰💰💰💰💰");
              successfulRuns++;
            }
            else
            {
              Console.WriteLine($"The bank's difficuly level is {temporaryBankDifficuly}.");
              Console.WriteLine("🚨🚨🚨🚨🚨");
              unsuccessfulRuns++;
            }
          }

          break;
        }

        teamMember.Add("MemberName", singleMemberName);
        Console.Write("Enter team member's skill level: (1 - 50) ");
        teamMember.Add("skillLevel", Console.ReadLine());
        Console.Write("Enter courage factor level: (0 - 2.0) ");
        teamMember.Add("courageFactor", Console.ReadLine());
        entireTeam.Add(teamMember);

        Console.Clear();
      }
      Console.WriteLine($"You had {successfulRuns} successful runs!");
      Console.WriteLine($"You had {unsuccessfulRuns} unsuccessful runs!");

    }

  }
}
