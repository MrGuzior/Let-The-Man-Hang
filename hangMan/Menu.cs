using System;
namespace hangMan
{
    public class Menu
    {
        public static void Handler(string input)
        {
            switch (input)
            {
                case "1":
                    singleGame();
                    break;
                case "2":
                    doubleGame();
                    break;
                case "q":
                case "Q":
                    Environment.Exit(0);
                    break;
                case "i":
                case "I":
                    displayInfo();
                    break;
                default:
                    Loops.MenuLoop();
                    break;
            }
        }

        public static void doubleGame()
        {
            Draw.drawMenu();
            Globals.namePlayer[0] = Player.setPlayer(1);
            Globals.namePlayer[1] = Player.setPlayer(2);
            Draw.doubleGameInput();
            Library.SetCategory(Console.ReadLine());
            Globals.gameState = "double";
        }

        public static void singleGame()
        {
            Library.GetPhrase();
            Globals.gameState = "single";
        }

        public static void displayInfo()
        {
            Draw.DrawInfo();
            Handler(Console.ReadLine());
        }
    }
}
