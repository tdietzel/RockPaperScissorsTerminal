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
      string player1 = Console.ReadLine();
      Console.WriteLine("Player 2's Roll");
      string player2 = Console.ReadLine();
      RPS game = new RPS(player1, player2);
      string result = game.Play();
      Console.WriteLine(result);
    }
  }
}
