using System;
namespace hangMan
{
    public class EndGame
    {
        //Check the round outcome
        public static bool lostGame()
        {
            bool output = false;

            if(Globals.triesLeft == 0)
            {
                output = true;
            }
            return output;
        }
        public static bool wonGame()
        {
            bool output = false;

            if (!Globals.phraseMarker.Contains("_"))
            {
                output = true;
            }

            return output;
        }
        //Check if the game has ended
        public static bool SingleEndGame()
        {
            bool output = false;
            if (Globals.livesLeft < 0)
            {
                output = true;
                Console.WriteLine(" Your total score: " + Globals.score);
                Console.WriteLine(" Press any button to continue...");
                Console.ReadKey();
                UpdateTable.restartGame();
            }
            return output;
        }
        public static bool DoubleEndGame()
        {
            bool output = false;
            if (Globals.roundsLeft < 1)
            {
                output = true;
                Console.WriteLine(" " + Globals.namePlayer[0]+"'s score: " + Globals.scorePlayer[0] + " points");
                Console.WriteLine(" " + Globals.namePlayer[1] + "'s score: " + Globals.scorePlayer[1] + " points");
                Console.WriteLine(" Press any button to continue...");
                Console.ReadKey();
                UpdateTable.restartGame();
            }
            return output;
        }

    }
}
