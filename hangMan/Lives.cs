using System;
namespace hangMan
{
    public class Lives
    {
        public static void UpdateLives(int update)
        {
            Globals.livesLeft = Globals.livesLeft + update;
        }
        public static void UpdateRounds(int update)
        {
            Globals.roundsLeft = Globals.roundsLeft + update;
        }
    }
}
