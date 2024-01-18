using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RPS.Tests
{
  [TestClass]
  public class RPSTests
  {
    [TestMethod]
    public void RPSContructor_CreatesInstanceOfRPS_RPS()
    {
      RPS newGame = new RPS();
      Assert.AreEqual(typeof(RPS), newGame.GetType());
    }
    [TestMethod]
    public void player1_win()
    {
      string game = new RPS();

      string result = game.Play("Paper", "Rock")
      Assert.AreEqual("Player 1", result);
    }
    [TestMethod]
    public void player2_win()
    {
     string game = new RPS();

      string result = game.Play("Paper", "Rock")
      Assert.AreEqual("Player 2", result);
    }
    [TestMethod]
    public void draw()
    {
      string game = new RPS();

      string result = game.Play("Paper", "Paper")
      Assert.AreEqual("Draw", result);
    }
  }
}