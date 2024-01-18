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
            else if (Player1 == "rock" && Player2 == "paper" && Player3 == "scissors" || Player2 == "rock" && Player3 == "paper" && Player1 == "scissors"|| Player3 == "rock" && Player1 == "paper" && Player2 == "scissors" )
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