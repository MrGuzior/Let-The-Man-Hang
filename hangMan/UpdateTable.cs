using System;
namespace hangMan
{
    public class UpdateTable
    {
        public static void updateTable(string input)
        {
            string alphabet = string.Join("", Globals.alphabet);
            int updateMarkerCount = alphabet.IndexOf(input.ToUpper());
            Globals.marker[updateMarkerCount] = "¯";
        }

        public static void restartTable()
        {
            for (int i = 0; i < Globals.alphabet.Length; i++)
            {
                Globals.marker[i] = " ";
            }
                Globals.triesLeft = Globals.triesLeftConst;
                Globals.inputCount = Globals.inputCountConst;
                Globals.hintsLeft = Globals.hintsLeftConst;
        }

        public static void restartGame()
        {
            for (int i = 0; i < Globals.alphabet.Length; i++)
            {
                Globals.marker[i] = " ";
            }
                Globals.triesLeft = Globals.triesLeftConst;
                Globals.inputCount = Globals.inputCountConst;
                Globals.hintsLeft = Globals.hintsLeftConst;
                Globals.score = Globals.scoreConst;
                Globals.livesLeft = Globals.livesLeftConst;
                Globals.scorePlayer[0] = Globals.scorePlayerConst[0];
                Globals.scorePlayer[1] = Globals.scorePlayerConst[1];
                Globals.namePlayer[0] = Globals.namePlayerConst[0];
                Globals.namePlayer[1] = Globals.namePlayerConst[1];
                Globals.gameState = "menu";
                Globals.roundsLeft = Globals.roundsLeftConst;
                Globals.guessingPlayer = Globals.guessingPlayerConst;
        }
    }
}
