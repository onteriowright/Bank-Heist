using System;
using System.Collections.Generic;

namespace heist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Lets plan a Heist!");
      Console.WriteLine("===================");

      Console.Write("What is the bank's difficulty level? ");

      int bankDifficulty = int.Parse(Console.ReadLine());

      if (bankDifficulty <= 50)
      {
        List<string> smallBanks = new List<string>()
        {
        "First Tennesee",
        "Regions",
        "Madison United"
        };

        Random index = new Random();
        int randIndex = index.Next(smallBanks.Count);

        Console.WriteLine("================================================");
        Console.WriteLine($"Looks like your robbing **{smallBanks[randIndex]} 🏦. Good Luck!");
        Console.WriteLine("================================================");

        Console.WriteLine($"This bank's level of difficulty is {bankDifficulty}! Robbing this bank should be a piece of cake!");
      }
      else if (bankDifficulty > 50 && bankDifficulty <= 75)
      {
        List<string> mediumBanks = new List<string>()
        {
        "Chase",
        "Clarksville Payway",
        "Truth Finacials"
        };

        Random index = new Random();
        int randIndex = index.Next(mediumBanks.Count);

        Console.WriteLine("================================================");
        Console.WriteLine($"Looks like your robbing **{mediumBanks[randIndex]} 🏦. Good Luck!");
        Console.WriteLine("================================================");

        Console.WriteLine($"This bank's level of difficulty is {bankDifficulty}! It's going take alot of luck to pull this one off!");
      }
      else if (bankDifficulty > 75 && bankDifficulty <= 90)
      {
        List<string> largeBanks = new List<string>()
        {
        "Bank of America",
        "Wells Fargo",
        "U.S. Bank"
        };

        Random index = new Random();
        int randIndex = index.Next(largeBanks.Count);

        Console.WriteLine("================================================");
        Console.WriteLine($"Looks like your robbing **{largeBanks[randIndex]} 🏦. Good Luck!");
        Console.WriteLine("================================================");

        Console.WriteLine($"This bank's level of difficulty is {bankDifficulty}! Your entering the big leagues! It's gonna take guts and skills to pull this one off! 💰💰💰💰💰");
      }
      else
      {
        Console.WriteLine($"Big Bank Hank!!!This bank's level of difficulty is {bankDifficulty}! It's the *****🏦🏦   Federal Reserve 🏦🏦 *****! Your going to need highly skilled professionals to pull this one off, but if you do you'll be swimming in money! 🏊🏊🏊💰💸🤑💰💸🤑💰💸🤑💰💸🤑💰💸🤑💰💸🤑");
      }

      Console.WriteLine("=========================================");

      int teamTotalSkillLevel = 0;
      int successfulRuns = 0;
      int unsuccessfulRuns = 0;

      List<CrewMembers> entireCrew = new List<CrewMembers>();
      while (true)
      {
        Console.Write("What is your name? ");

        string individualMembersName = Console.ReadLine();

        if (individualMembersName == "")
        {
          if (entireCrew.Count == 0)
          {
            Console.WriteLine("Can't rob a bank with no members!");
          }
          else if (entireCrew.Count == 1)
          {
            Console.WriteLine($"May need more than {entireCrew.Count} member to get the job done!");
          }
          else if (entireCrew.Count <= 4 && bankDifficulty > 75 && teamTotalSkillLevel < bankDifficulty)
          {
            Console.WriteLine($"With only {entireCrew.Count} people, I really hope you know what your getting yourself into. You only have a combined skill level of {teamTotalSkillLevel} and the bank difficulty is {bankDifficulty}!");
          }
          else
          {
            Console.WriteLine($"A crew of {entireCrew.Count}! Let's Gooooo!");
          }

          Console.WriteLine("===========================================");
          Console.Write("How many times should we run the process to figure your luck? ");

          int heistRuns = int.Parse(Console.ReadLine());

          for (int i = 0; i < heistRuns; i++)
          {
            Random heistLuck = new Random();
            int temporaryBankDifficulty = bankDifficulty;
            int heistLuckInt = heistLuck.Next(-10, 11);
            temporaryBankDifficulty += heistLuckInt;

            Console.WriteLine("============================================");
            Console.WriteLine($"The team's combined skill level is {teamTotalSkillLevel} and the banks difficulty level is {temporaryBankDifficulty}");
            Console.WriteLine("============================================");

            if (teamTotalSkillLevel > temporaryBankDifficulty)
            {
              Console.WriteLine("💰💰💰💰💰!!!");
              successfulRuns++;
            }
            else
            {
              Console.WriteLine("🚔👮🚓🚨🚨🚨🚨🚨");
              unsuccessfulRuns++;
            }
          }

          break;
        }

        Console.Write("What is your skill level? Enter number 1 - 50: ");
        int skillLevel = int.Parse(Console.ReadLine());

        if (skillLevel < 1)
        {
          skillLevel = 1;
          Console.WriteLine(skillLevel);
        }
        else if (skillLevel > 50)
        {
          skillLevel = 50;
          Console.WriteLine(skillLevel);

        }

        teamTotalSkillLevel += skillLevel;

        Console.Write("What is your courage factor? Enter decimal 0.0 - 2.0: ");
        string courageFactor = Console.ReadLine();
        decimal courageFactorDecimal = decimal.Parse(courageFactor);

        CrewMembers entireCrews = new CrewMembers()
        {
          Name = individualMembersName,
          SkillLevel = skillLevel,
          CourageFactor = courageFactorDecimal

        };
        entireCrew.Add(entireCrews);
        Console.Clear();
      }

      Console.WriteLine("===============================================");
      Console.WriteLine($"You had {successfulRuns} successful runs!");
      Console.WriteLine("===============================================");
      Console.WriteLine($"You had {unsuccessfulRuns} unsuccessful runs!");
      Console.WriteLine("===============================================");

      if (unsuccessfulRuns >= successfulRuns)
      {
        Console.WriteLine("It will be a cold day in hell before you pull this off!");
      }
      else
      {
        Console.WriteLine("Baby Yoda is with you and so is all the force!");
      }
    }

  }
}