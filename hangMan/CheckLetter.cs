using System;
namespace hangMan
{
    public class CheckLetter
    {
        public static void checkLetter()
        {
            char[] phrase = Globals.phrase.ToLower().ToCharArray();
            char[] alphabetChar = string.Join("", Globals.alphabet).ToLower().ToCharArray();
            char[] outputPhrase = new char[phrase.Length];

            for (int i = 0; i < Globals.alphabet.Length; i++)
            {
                for (int j = 0; j < phrase.Length; j++)
                {
                    if (phrase[j] != alphabetChar[i])
                    {
                        outputPhrase[j] = '_';
                    }
                }
            }

            for (int i = 0; i < Globals.alphabet.Length; i++)
            {
                if (Globals.inputCount <= 0)
                {
                    for (int j = 0; j < phrase.Length; j++)
                    {
                        if (phrase[j] == ' ')
                        {
                            outputPhrase[j] = ' ';
                        }
                        else
                        {
                            outputPhrase[j] = '_';
                        }
                    }
                }
                if (Globals.marker[i] == "¯")
                {
                    for (int j = 0; j < phrase.Length; j++)
                    {
                       if (phrase[j] == alphabetChar[i])
                        {
                            outputPhrase[j] = alphabetChar[i];
                        }
                        if(phrase[j] == ' ')
                        {
                            outputPhrase[j] = ' ';
                        }
                    }
                }
            }
            
            Globals.phraseMarker = string.Join(" ", outputPhrase).ToUpper();
        }
    }
}
