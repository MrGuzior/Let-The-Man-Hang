using System;
namespace hangMan
{
    public class Draw
    {
        public static void DrawSingleGame()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ " + string.Join("  ", Globals.alphabet) + " ║");
            Console.WriteLine("║ " + string.Join("  ", Globals.marker) + " ║");
            Console.WriteLine("║ " + Globals.image[Globals.triesLeft][0] + "                                                                   ║");
            Console.WriteLine("║ " + Globals.image[Globals.triesLeft][1] + "                                                                   ║");
            Console.WriteLine("║ " + Globals.image[Globals.triesLeft][2] + Line.calculateLine(67, Globals.phraseMarker) + "║");
            Console.WriteLine("║ " + Globals.image[Globals.triesLeft][3] + "                                                                   ║");
            Console.WriteLine("║ " + Globals.image[Globals.triesLeft][4] + "                                                                   ║");
            Console.WriteLine("╠═══════════════════════╦═════════════════╦══════════╦══════════════╦══════════╣");
            Console.Write    ("║ Category: "+ Line.calculateLine(12, Globals.category) +"║");
            Console.WriteLine(                         " Hints: " + Globals.hintsLeft + " [hint] ║ Lives: "+ Globals.livesLeft +" ║ Score:" + Line.calculateLine(7, Globals.score.ToString()) + "║  [menu]  ║");
            Console.WriteLine("╚═══════════════════════╩═════════════════╩══════════╩══════════════╩══════════╝");
            Console.WriteLine("");
            if (!EndGame.SingleEndGame())
            {
                Console.Write(" Input a letter: ");
            }
        }

        public static void DrawDoubleGame()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ " + string.Join("  ", Globals.alphabet) + " ║");
            Console.WriteLine("║ " + string.Join("  ", Globals.marker) + " ║");
            Console.WriteLine("║ " + Globals.image[Globals.triesLeft][0] + "                                                                   ║");
            Console.WriteLine("║ " + Globals.image[Globals.triesLeft][1] + "                                                                   ║");
            Console.WriteLine("║ " + Globals.image[Globals.triesLeft][2] + Line.calculateLine(67, Globals.phraseMarker) + "║");
            Console.WriteLine("║ " + Globals.image[Globals.triesLeft][3] + "                                                                   ║");
            Console.WriteLine("║ " + Globals.image[Globals.triesLeft][4] + "                                                                   ║");
            Console.WriteLine("╠═══════════════════════╦═════════════════╦═════════════════════════╦══════════╣");
            Console.WriteLine("║ Category: " + Line.calculateLine(12, Globals.category) + "║ Hints: " + Globals.hintsLeft + " [hint] ║     Rounds left: "+Globals.roundsLeft/2 +"      ║  [menu]  ║");
            Console.WriteLine("╠════════════╦══════════╩═╦═══════════════╩═════════════════════╦═══╩══════════╣");
            Console.WriteLine("║  Player 1  ║ "+ Line.calculateLine(10, Globals.namePlayer[0]) + " ║             Score: " + Line.calculateLine(4, Globals.scorePlayer[0].ToString()) + "            " + " ║ "+ Line.calculateLine(12, Globals.nowGuessing[0]) +" ║");
            Console.WriteLine("╠════════════╬════════════╬═════════════════════════════════════╬══════════════╣");
            Console.WriteLine("║  Player 2  ║ "+ Line.calculateLine(10, Globals.namePlayer[1]) + " ║             Score: "+ Line.calculateLine(4, Globals.scorePlayer[1].ToString()) +"            " + " ║ " + Line.calculateLine(12, Globals.nowGuessing[1]) + " ║");
            Console.WriteLine("╚════════════╩════════════╩═════════════════════════════════════╩══════════════╝");

            Console.WriteLine("");
            if (!EndGame.DoubleEndGame())
            {
                Console.Write(" Input a letter: ");
            }
        }

        public static void drawMenu()
        {
            Console.Clear();
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                       _    _          _   _  _____ __  __          _   _    ║");
            Console.WriteLine("║  ╔═════╗             | |  | |   /\\   | \\ | |/ ____|  \\/  |   /\\   | \\ | |   ║");
            Console.WriteLine("║  ║     ○             | |__| |  /  \\  |  \\| | |  __| \\  / |  /  \\  |  \\| |   ║");
            Console.WriteLine("║  ║   / | \\           |  __  | / /\\ \\ | . ` | | |_ | |\\/| | / /\\ \\ | . ` |   ║");
            Console.WriteLine("║  ║    / \\            | |  | |/ ____ \\| |\\  | |__| | |  | |/ ____ \\| |\\  |   ║");
            Console.WriteLine("║  ╚═                  |_|  |_/_/    \\_\\_| \\_|\\_____|_|  |_/_/    \\_\\_| \\_|   ║");
            Console.WriteLine("║                                                               By MrGuzior   ║");
            Console.WriteLine("╠═════════════════════╦═══════════════════╦════════════╦══════════════════════╣");
            Console.WriteLine("║  Single player [1]  ║  Two players [2]  ║  Info [I]  ║  Exit the game [Q]   ║");
            Console.WriteLine("╚═════════════════════╩═══════════════════╩════════════╩══════════════════════╝");
            Console.WriteLine(" ");
        }

        public static void doubleGameInput()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════╦═══════════════════╦══════════════════╦═══════════════════╗");
            Console.WriteLine("║ Select  category ║   Geography [0]   ║    Weather [1]   ║    Animals [2]    ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╬══════════════════╬═══════════════════╣");
            Console.WriteLine("║    Plants [3]    ║      Food [4]     ║  Measurement [5] ║     Music [6]     ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╬══════════════════╬═══════════════════╣");
            Console.WriteLine("║    Sports [7]    ║      Body [8]     ║    Science [9]   ║   Computer [10]   ║");
            Console.WriteLine("╠══════════════════╩═══════════════════╩══════════════════╩═══════════════════╣");
            Console.WriteLine("║                          Input your own phrase [i]                          ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.Write(" Your choise: ");
        }

        public static void DrawInfo()
        {
            Console.WriteLine("Version 1.0");
            Console.WriteLine("Created by MrGuzior");
            Console.WriteLine("All rights reserved");
        }
    }
}
