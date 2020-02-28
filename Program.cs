using System;
using System.Collections.Generic;

namespace heist
{
  class Program
  {
    static void Main(string[] args)
    {
      int memberCount = 0;
      int bankDifficultyLevel = 100;
      int sumSkillLevel = 0;
      int teamMemberSkillLevelInt = 0;
      int sum = 0;
      int total = 0;

      Console.WriteLine("Plan your heist");

      while (true)
      {
        sumSkillLevel = sum;
        Console.WriteLine("Enter team member's name...");
        string teamMemberName = Console.ReadLine();

        if (teamMemberName == "")
        {
          if (total < bankDifficultyLevel)
          {
            Console.WriteLine("Squad not strong enough");
          }
          else
          {
            Console.WriteLine("Let's rob a bank!");
          }

          Console.WriteLine("You did not enter a name!");
          break;
        }

        Console.WriteLine("Enter skill level...");
        string teamMemberSkillLevel = Console.ReadLine();
        teamMemberSkillLevelInt = int.Parse(teamMemberSkillLevel);
        Console.WriteLine("Enter your courage factor...");
        string teamMemberCourageFactor = Console.ReadLine();
        decimal teamMemberCourageFactorDecimal = decimal.Parse(teamMemberCourageFactor);
        memberCount++;
        if (memberCount == 1)
        {
          Console.WriteLine($"Their is {memberCount} memeber in your crew");
        }
        else
        {

          Console.WriteLine($"Their are {memberCount} memebers in your crew");
        }

        sum = teamMemberSkillLevelInt;


        total = sum + sumSkillLevel;
        Console.WriteLine(total);

        Console.WriteLine($"{teamMemberName}'s skill level is {teamMemberSkillLevelInt} and your courage factor is {teamMemberCourageFactorDecimal}");
      }





    }
  }
}
