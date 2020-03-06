using System;
namespace hangMan
{
    public class Player
    {
        public static string setPlayer(int player)
        {
            Console.Write(" Player " + player + " name: ");
            string input = Console.ReadLine();
            while (input.Length > 10)
            {
                Console.WriteLine(" Name too long");
                Console.Write(" Player " + player + " name: ");
                input = Console.ReadLine();
            }
            return input;
        }

        public static void guessingPlayer()
        {
            if(Globals.roundsLeft % 2 == 0)
            {
                Globals.nowGuessing[1] = "";
                Globals.nowGuessing[0] = "Now guessing";
                Globals.guessingPlayer = 0;
            }
            else
            {
                Globals.nowGuessing[0] = "";
                Globals.nowGuessing[1] = "Now guessing";
                Globals.guessingPlayer = 1;
            }
        }
    }
}