using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void RPS_isTie_String()
    {
      string playerOneInput = "rock";
      string playerTwoInput = "rock";

      Assert.AreEqual("tie", RPS.Shoot(playerOneInput, playerTwoInput));
    }
    [TestMethod]
    public void RPS_Player1WinPaper_String()
    {
      string playerOneInput = "paper";
      string playerTwoInput = "rock";
      Assert.AreEqual("Player1 wins!", RPS.Shoot(playerOneInput, playerTwoInput));
    }
    [TestMethod]
    public void RPS_Player1WinScissors_String()
    {
      string playerOneInput = "scissors";
      string playerTwoInput = "paper";
      Assert.AreEqual("Player1 wins!", RPS.Shoot(playerOneInput, playerTwoInput));
    }
    [TestMethod]
    public void RPS_Player1WinRock_String()
    {
      string playerOneInput = "rock";
      string playerTwoInput = "scissors";
      Assert.AreEqual("Player1 wins!", RPS.Shoot(playerOneInput, playerTwoInput));
    }

    [TestMethod]
    public void RPS_Player2WinPaper_String()
    {
      string playerOneInput = "rock";
      string playerTwoInput = "paper";
      Assert.AreEqual("Player2 wins!", RPS.Shoot(playerOneInput, playerTwoInput));
    }
    [TestMethod]
    public void RPS_Player2WinScissors_String()
    {
      string playerOneInput = "paper";
      string playerTwoInput = "scissors";
      Assert.AreEqual("Player2 wins!", RPS.Shoot(playerOneInput, playerTwoInput));
    }
    [TestMethod]
    public void RPS_Player2WinRock_String()
    {
      string playerOneInput = "scissors";
      string playerTwoInput = "rock";
      Assert.AreEqual("Player2 wins!", RPS.Shoot(playerOneInput, playerTwoInput));
    }
  }
}