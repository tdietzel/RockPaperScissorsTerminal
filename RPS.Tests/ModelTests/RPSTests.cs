using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RPSTests
  {
    [TestMethod]
    public void RPSConstructor_CreatesInstanceOfRPS_RPS()
    {
      RPS newGame = new RPS("Rock", "Scissors");
      Assert.AreEqual(typeof(RPS), newGame.GetType());
    }
    [TestMethod]
    public void player1_win()
    {
      RPS game = new RPS("Paper", "Rock");
      string result = game.Play();
      Assert.AreEqual("player 1 wins", result);
    }
    [TestMethod]
    public void player2_win()
    {
     RPS game = new RPS("Rock", "Paper");
      string result = game.Play();
      Assert.AreEqual("player 2 wins", result);
    }
    [TestMethod]
    public void draw()
    {
      RPS game = new RPS("Paper", "Paper");
      string result = game.Play();
      Assert.AreEqual("It's a draw", result);
    }
  }
}