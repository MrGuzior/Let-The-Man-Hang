using System;
namespace hangMan
{
    public class RandomPhrase
    {
        public static int getRandomPhrase(string part, int category)
        {
            Random random = new Random();
            int output = 0;
            if (part == "category")
            {
                output = random.Next(0, category);
            }
            if (part == "word")
            {
                output = random.Next(0, Library.list[category].Length);
            }
            return output;
        }
    }
}
