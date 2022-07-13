using System;
using RockPaperScissors.Models;

namespace RockPaperScissors.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("How many players? (1/2)");
      int players = int.Parse(Console.ReadLine());

      Console.WriteLine("Player One Turn");
      string playerOneInput = Console.ReadLine();
      string playerTwoInput = "";

      if (players == 1) {
        string[] outputs = { "rock", "paper", "scissors" };
        Random rand = new Random();
        int computer = rand.Next(0, 2);
        playerTwoInput = outputs[computer];
        Console.WriteLine("Player Two threw:\n" + playerTwoInput);

      } else if (players == 2) {
        Console.WriteLine("Player Two Turn");
        playerTwoInput = Console.ReadLine();

      } else {
        Console.WriteLine("I didn't catch that, please enter 1 or 2");
        Main();
      }
      
      Console.WriteLine(RPS.Shoot(playerOneInput.ToLower(), playerTwoInput.ToLower()));
    }
  }
}