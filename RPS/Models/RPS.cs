namespace RockPaperScissors.Models
{
  public class RPS
  {
    public string Player1 { get; set; }
    public string Player2 { get; set; }
    public string Player3 { get; set; }

    public RPS(string firstRoll, string secondRoll, string thirdRoll)
    {
      Player1 = firstRoll;
      Player2 = secondRoll;
      Player3 = thirdRoll;
    }

    public RPS(string firstRoll, string secondRoll)
    {
      Player1 = firstRoll;
      Player2 = secondRoll;
    }

    public string TwoPlay()
    {
      if (Player1 == Player2)
      {
        return "It's a draw";
      }
      else if (
        (Player1 == "rock") && (Player2 == "scissors") ||
        (Player1 == "paper") && (Player2 == "rock") ||
        (Player1 == "scissors") && (Player2 == "paper")
      )
      {
        return "player 1 wins";
      }
      else
      {
        return "player 2 wins";
      }
    }

    public string Play()
    {
      if (Player1 == Player2 && Player2 == Player3)
      {
        return "It's a draw";
      }
      else if (Player1 == Player2)
      {
        return "Player1 and Player2 have drawn";
      }
      else if (Player1 == Player3)
      {
        return "Player1 and Player3 have drawn";
      }
      else if (Player2 == Player3)
      {
        return "Player2 and Player3 have drawn";
      }
      else if (Player1 == "rock" && Player2 == "scissors" && Player3 == "scissors")
      {
        return "player 1 wins";
      }
      else if (Player1 == "paper" && Player2 == "rock" && Player3 == "rock")
      {
        return "player 1 wins";
      }
      else if (Player1 == "scissors" && Player2 == "paper" && Player3 == "paper")
      {
        return "player 1 wins";
      }
      else if (Player2 == "rock" && Player1 == "scissors" && Player3 == "scissors")
      {
        return "player 2 wins";
      }
      else if (Player2 == "paper" && Player1 == "rock" && Player3 == "rock")
      {
        return "player 2 wins";
      }
      else if (Player2 == "scissors" && Player1 == "paper" && Player3 == "paper")
      {
        return "player 2 wins";
      }
      else if (Player1 == "rock" && Player2 == "paper" && Player3 == "scissors" || Player2 == "rock" && Player3 == "paper" && Player1 == "scissors" || Player3 == "rock" && Player1 == "paper" && Player2 == "scissors")
      {
        return "No one wins";
      }
      else
      {
        return "Player 3 Wins";
      }
    }
  }
}


// {
//   public class RPS
//   {
//     public string Player1 { get; set; }
//     public string Player2 { get; set; }

//     public RPS(string firstRoll, string secondRoll)
//     {
//       Player1 = firstRoll;
//       Player2 = secondRoll;
//     }

//     public string Play()
//     {
//       if (Player1 == Player2)
//       {
//         return "It's a draw";
//       }
//       else if (
//         (Player1 == "Rock" || Player1 == "rock" || Player1 == "ROCK") &&
//         (Player2 == "Scissors" || Player2 == "scissors" || Player2 == "SCISSORS") ||
//         (Player1 == "Paper" || Player1 == "PAPER" || Player1 == "paper") &&
//         (Player2 == "Rock" || Player2 == "ROCK" || Player2 == "rock") ||
//         (Player1 == "Scissors" || Player1 == "scissors" || Player1 == "SCISSORS") &&
//         (Player2 == "Paper" || Player2 == "PAPER" || Player2 == "paper")
//       )
//       {
//         return "player 1 wins";
//       }
//       else
//       {
//         return "player 2 wins";
//       }
//     }
//   }
// }

// Player Wins
// Rock, scissors, scissors
// Paper, rock, rock
// Scissors, paper, paper
// Paper, rock, scissors
// 
// Player Ties
// Player1 == Player2 || Player1 == Player3 || Player3 == Player2
// Player1 == Player2 == Player3
// 