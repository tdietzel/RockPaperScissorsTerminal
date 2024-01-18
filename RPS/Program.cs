using System;
using RockPaperScissors.Models;

namespace ExampleName
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("This is a Rock Paper Scissors game.");
      PlayersInput();
      static void PlayersInput()
      {
        Console.WriteLine("Are you playing with '2' or '3' players? Enter below:");
        string gameType = Console.ReadLine();
        if(gameType == "2")
        {
        Console.WriteLine("Please enter Rock, Paper, or Scissors.");
        Console.WriteLine("Player 1's Roll");
        string player1 = Console.ReadLine().ToLower();
        Console.WriteLine("Player 2's Roll");
        string player2 = Console.ReadLine().ToLower();
        RPS game = new RPS(player1, player2);
        string result = game.TwoPlay();
        Console.WriteLine(result);
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
        Console.WriteLine(result);
        }
        else
        {
        Console.WriteLine("Please enter a valid number of players");
        PlayersInput();
        }
      }
    }
  }
}
