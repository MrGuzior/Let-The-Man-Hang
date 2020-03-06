using System;
namespace hangMan
{
    public class Hint
    {
        public static string GetHint()
        {
            string stringOutput = "";
            if ((!EndGame.DoubleEndGame() || !EndGame.SingleEndGame()) && Globals.hintsLeft > 0)
            {
                char[] phrase = Globals.phrase.ToLower().ToCharArray();
                Array.Reverse(phrase);
                char[] alphabet = string.Join("", Globals.alphabet).ToLower().ToCharArray();
                bool output = true;

                for (int i = 0; i < phrase.Length; i++)
                {
                    for (int j = 0; j < alphabet.Length && output; j++)
                    {
                        if (phrase[i] == alphabet[j] && Globals.marker[j] != "¯")
                        {
                            stringOutput =  Globals.alphabet[j];
                            output = false;
                        }
                    }
                }
                    Globals.hintsLeft--;
                    return stringOutput;
            }
            else
            {
                Console.WriteLine(" No hints left");
                return stringOutput;
            };
        }
    }
}
