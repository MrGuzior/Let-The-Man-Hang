using System;
namespace hangMan
{
  public class Outcome
  {
    public static bool isGameLost() => Globals.triesLeft == 0;
    public static bool isGameWon() => !Globals.phraseMarker.Contains("_");

    public static bool isSingleGameDone()
    {
      bool handleGameEnd()
      {
        Console.WriteLine(" Your total score: " + Globals.score);
        Console.WriteLine(" Press any button to continue...");
        Console.ReadKey();
        UpdateTable.restartGame();
        return true;
      }
      return Globals.livesLeft < 0 && handleGameEnd();
    }

    public static bool isDoubleGameDone()
    {
      bool handleGameEnd()
      {
        Console.WriteLine(" " + Globals.namePlayer[0] + "'s score: " + Globals.scorePlayer[0] + " points");
        Console.WriteLine(" " + Globals.namePlayer[1] + "'s score: " + Globals.scorePlayer[1] + " points");
        Console.WriteLine(" Press any button to continue...");
        Console.ReadKey();
        UpdateTable.restartGame();
        return true;
      }
      return Globals.roundsLeft < 1 && handleGameEnd();
    }

    public static void handleSingleRoundOutcome(bool isRoundWon)
    {
      Draw.DrawSingleGame();
      Console.WriteLine("");
      if (isRoundWon)
      {
        Console.Write("The man lives!");
        if (isSingleGameDone())
        {
          Globals.score = Globals.score + Score.calcScore();
        }
        Console.WriteLine(" Press any button to continue...");
        Lives.UpdateLives(0);

      }
      else
      {
        Console.WriteLine(" You let the man hang...");
        if (isSingleGameDone())
        {
          Globals.score = Globals.score + Score.calcScore();
        }
          Lives.UpdateLives(-1);
        
        Console.Write(" The phrase was: " + Globals.phrase);
      }
      Console.WriteLine("");
      Console.ReadKey();
      Library.GetPhrase();
      UpdateTable.restartTable();//rerender?
      CheckLetter.checkLetter();
    }





  }
}
