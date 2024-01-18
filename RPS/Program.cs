using System;
using RockPaperScissors.Models;

namespace ExampleName
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("This is a Rock Paper Scissors game.");
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
  }
}
