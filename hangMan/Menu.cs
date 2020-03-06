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
                    Library.GetPhrase();
                    Globals.gameState = "single";
                    break;
                case "2":
                    doubleGame();
                    Globals.gameState = "double";
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
            Globals.namePlayer[0] = Player.setPlayer(1);
            Globals.namePlayer[1] = Player.setPlayer(2);
            Draw.doubleGameInput();
            if (Console.ReadLine().ToLower() == "i") { PhraseInput.GetPhrase(); Library.GetCategory(Library.list.Length + 1); } else { Library.GetPhrase(); }
            
        }

        public static void displayInfo()
        {
            Draw.DrawInfo();
            Handler(Console.ReadLine());
        }
    }
}
