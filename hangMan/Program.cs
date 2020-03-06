using System;

namespace hangMan
{
    class MainClass
    {
        public static void Main()
        {
            do
            {
                switch (Globals.gameState)
                {
                    case "menu":
                        Loops.MenuLoop();
                        break;
                    case "single":
                        Loops.SingleGameLoop();
                        break;
                    case "double":
                        Loops.DoubleGameLoop();
                        break;
                    default:
                        Globals.gameState = "menu";
                        break;
                }
            } while (true);
        }
    }
}
