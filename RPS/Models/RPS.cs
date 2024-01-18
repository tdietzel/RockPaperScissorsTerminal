namespace RockPaperScissors.Models
{
  public class RPS
  {
    public string Player1 { get; set; }
    public string Player2 { get; set; }

    public RPS(string firstRoll, string secondRoll)
    {
      Player1 = firstRoll;
      Player2 = secondRoll;
    }

    public string Play()
    {
      if (Player1 == Player2)
      {
        return "It's a draw";
      }
      else if (
        (Player1 == "Rock" || Player1 == "rock" || Player1 == "ROCK") &&
        (Player2 == "Scissors" || Player2 == "scissors" || Player2 == "SCISSORS") ||
        (Player1 == "Paper" || Player1 == "PAPER" || Player1 == "paper") &&
        (Player2 == "Rock" || Player2 == "ROCK" || Player2 == "rock") ||
        (Player1 == "Scissors" || Player1 == "scissors" || Player1 == "SCISSORS") &&
        (Player2 == "Paper" || Player2 == "PAPER" || Player2 == "paper")
      )
      {
        return "player 1 wins";
      }
      else
      {
        return "player 2 wins";
      }
    }
  }
}