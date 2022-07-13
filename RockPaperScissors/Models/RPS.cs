namespace RockPaperScissors.Models
{
  public class RPS
  {
    public static string Shoot(string player1, string player2)
    {
      if (player1 == player2) 
      {
        return "tie";
      }
      else if ((player1 == "rock" && player2 == "scissors") || (player1 == "scissors" && player2 == "paper") || (player1 == "paper" && player2 == "rock")) 
      {
        return "Player1 wins!";
      } 
      else 
      {
        return "Player2 wins!";
      }
    }
  }
}