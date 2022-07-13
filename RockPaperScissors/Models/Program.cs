using System;
using RockPaperScissors.Models;

namespace RockPaperScissors.Models
{
  public class Program
  {
    public static void Main()
    {
      // computer logic
      string[] outputs = { "rock", "paper", "scissors" };
      Random rand = new Random();
      int computer = rand.Next(0, 2);
      string computerInput = outputs[computer];

      // player logic
      Console.WriteLine("Player One Turn");
      string playerOneInput = Console.ReadLine();

      Console.WriteLine("The Computer threw:\n" + computerInput);
      Console.WriteLine(RPS.Shoot(playerOneInput.ToLower(), computerInput));
    }
  }
}