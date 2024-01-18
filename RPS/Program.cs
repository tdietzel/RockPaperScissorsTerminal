using System;
using RockPaperScissors.Models;
using RockPaperScissors.UserInterfaceModels;

namespace ExampleName
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(RockPaperScissors.UserInterfaceModels.WelcomeBanner.Welcome);
      // Console.WriteLine(RockPaperScissors.UserInterfaceModels.Player1WinBanner.Player1Win);
      // Console.WriteLine(RockPaperScissors.UserInterfaceModels.Player2WinBanner.Player1Win);
      // Console.WriteLine(RockPaperScissors.UserInterfaceModels.Player3WinBanner.Player3Win);
      Console.WriteLine("This is a Rock Paper Scissors game.");
      PlayersInput();
      static void PlayersInput()
      {
        Console.WriteLine("Are you playing with '2' or '3' players? Enter below:");
        string gameType = Console.ReadLine();
        if (gameType == "2")
        {
          Console.WriteLine("Please enter Rock, Paper, or Scissors.");
          Console.WriteLine("Player 1's Roll");
          string player1 = Console.ReadLine().ToLower();
          Console.WriteLine("Player 2's Roll");
          string player2 = Console.ReadLine().ToLower();
          RPS game = new RPS(player1, player2);
          string result = game.TwoPlay();
          if (result == "player 1 wins")
          {
            Console.WriteLine(RockPaperScissors.UserInterfaceModels.Player1WinBanner.Player1Win);
          }
          else if (result == "player 2 wins")
          {
            Console.WriteLine(RockPaperScissors.UserInterfaceModels.Player2WinBanner.Player2Win);
          }
          else
          {
            Console.WriteLine(RockPaperScissors.UserInterfaceModels.DrawBanner.Draw);

          }
        }
        else if (gameType == "3")
        {
          Console.WriteLine("Please enter Rock, Paper, or Scissors.");
          Console.WriteLine("Player 1's Roll");
          string player1 = Console.ReadLine().ToLower();
          Console.WriteLine("Player 2's Roll");
          string player2 = Console.ReadLine().ToLower();
          Console.WriteLine("Player 3's Roll");
          string player3 = Console.ReadLine().ToLower();
          RPS game = new RPS(player1, player2, player3);
          string result = game.Play();
          if (result == "player 1 wins")
          {
            Console.WriteLine(RockPaperScissors.UserInterfaceModels.Player1WinBanner.Player1Win);
          }
          else if (result == "player 2 wins")
          {
            Console.WriteLine(RockPaperScissors.UserInterfaceModels.Player2WinBanner.Player2Win);
          }
          else if (result == "player 3 wins")
          {
            Console.WriteLine(RockPaperScissors.UserInterfaceModels.Player3WinBanner.Player3Win);
          }
          else
          {
            Console.WriteLine(RockPaperScissors.UserInterfaceModels.DrawBanner.Draw);
          }
        }
        else
        {
          Console.WriteLine("Please enter a valid number of players");
          PlayersInput();
        }
        Console.WriteLine("Would you like to play another game? Enter 'yes' or 'no'");
        if (Console.ReadLine() == "yes" || Console.ReadLine() == "Y" || Console.ReadLine() == "y")
        {
          PlayersInput();
        }
        else
        {
          Console.WriteLine(RockPaperScissors.UserInterfaceModels.GoodbyeBanner.Goodbye);
        }
      }
    }
    
  }
}
