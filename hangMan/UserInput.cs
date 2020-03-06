using System;
namespace hangMan
{
    public class UserInput
    {


        public static void userInput()
        {
            string input = Console.ReadLine();
            while (wasUsed(input) || input.Length != 1 || invalidLetter(input) || input == "hint")
            {
                while (wasUsed(input))
                {
                    Console.WriteLine(" You already used this letter.");
                    Console.Write(" Input a letter: ");
                    input = Console.ReadLine();
                }
                while (input == "")
                {
                    Console.Write(" Input a letter: ");
                    input = Console.ReadLine();
                }
                while (input.Length != 1 && input != "hint" && input != "menu")
                {
                    Console.WriteLine(" You can only input one letter.");
                    Console.Write(" Input a letter: ");
                    input = Console.ReadLine();
                }
                while (invalidLetter(input) && input != "hint" && input.Length == 1 && input != "menu")
                {
                    Console.WriteLine(" Invalid character.");
                    Console.Write(" Input a letter: ");
                    input = Console.ReadLine();
                }
                while (input.Length != 1 && input == "hint")
                {
                    input = Hint.GetHint();
                }
                while (input.Length != 1 && input == "menu")
                {
                    UpdateTable.restartGame();
                    MainClass.Main();
                }
            }
            UpdateImage.updateImage(input);
            UpdateTable.updateTable(input);
            Globals.inputCount++;

        }

        public static bool wasUsed(string input)
        {
            bool output = false;

            for (int i = 0; i < Globals.alphabet.Length; i++)
            {
                if (Globals.alphabet[i].ToLower() == input.ToLower())
                {
                    if (Globals.marker[i] == "¯")
                    {
                        output = true;
                    }
                }
            }
            return output;
        }

        public static bool invalidLetter(string input)
        {
            bool output = true;
            for (int i = 0; i < Globals.alphabet.Length; i++)
            {
                if (Globals.alphabet[i].ToLower() == input.ToLower())
                {
                    output = false;
                }
            }
            return output;
        }
    }
}
