using System;
namespace hangMan
{
    public class PhraseMarker
    {
        public static void phraseMarker()
        {
            char[] phrase = Globals.phrase.ToCharArray();
            char[] phraseMarker = new char[phrase.Length];
            for(int i = 0; i < phrase.Length; i++)
            {
                        if (phrase[i] == ' ')
                        {
                            phraseMarker[i] = ' ';
                        }
                        else
                        {
                            phraseMarker[i] = '_';
                        }
            }
            Globals.phraseMarker = string.Join(" ", phraseMarker).ToUpper();
        }
    }
}
