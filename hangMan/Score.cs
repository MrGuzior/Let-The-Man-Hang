using System;
namespace hangMan
{
    public class Score
    {
        public static int calcScore()
        {
                int points = (Globals.triesLeft * 2) + (Globals.hintsLeft * 12) + 8;
            return points;
        }
    }
}
