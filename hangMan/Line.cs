using System;
namespace hangMan
{
    public class Line
    {
        public static string calculateLine(int lineLength, string input)
        {
            int lineLeft = (lineLength - input.Length) / 2;
            string lineHolderLeft = new string(' ', lineLeft);
            string lineHolderRight = new string(' ', lineLeft);
            string display;
            if (input.Length % 2 == 0 && lineLength % 2 != 0)
            {
                lineHolderRight = new string(' ', lineLeft + 1);
            }
            if (input.Length % 2 != 0 && lineLength % 2 == 0)
            {
                lineHolderRight = new string(' ', lineLeft + 1);
            }
            display = lineHolderLeft + input + lineHolderRight;
            return display;
        }
    }
}
