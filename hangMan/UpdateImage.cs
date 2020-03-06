using System;
namespace hangMan
{
    public class UpdateImage
    {
        public static void updateImage(string input)
        {
            if (!Globals.phrase.ToLower().Contains(input.ToLower()))
            {
                Globals.triesLeft--;
            }
        }
    }
}
