using System;
namespace hangMan
{
    public class PhraseInput
    {
        public static void GetPhrase()
        {
            string input;
            do
            {
                Console.Write(" Input phrase: ");
                input = Console.ReadLine();
            } while (CheckPhrase(input));
            Globals.phrase = input;
        }

        public static bool CheckPhrase(string input)
        {
            char[] phrase = input.ToCharArray();
            string alphabet = string.Join("", Globals.alphabet);
            bool output = false;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (!alphabet.ToLower().Contains(phrase[i].ToString().ToLower()) && phrase[i] != ' ')
                {
                    output = true;
                }
            }

            if (output)
            {
                Console.WriteLine(" Phrase contains invalid symbols");
            }

            if (phrase.Length > 25)
            {
                Console.WriteLine(" Max phrase length is 25 characters!");
                output = true;
            }
            return output;
        }
    }
}
