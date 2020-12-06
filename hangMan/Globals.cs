using System;
namespace hangMan
{
    public static class Globals
    {
        //Static variables
        public const int inputCountConst = 0;
        public const int triesLeftConst = 9;
        public const int hintsLeftConst = 2;
        public const int scoreConst = 0;
        public const int livesLeftConst = 1; //3
        public const string categoryConst = "";
        public static int[] scorePlayerConst = { 0, 0 };
        public static string[] namePlayerConst = { "", "" };
        public static string[] nowGuessingConst = { "Now Guessing", "" };
        public const int guessingPlayerConst = 0;
        public const int roundsLeftConst = 10;

        //Dynamic variables
        public static int inputCount = inputCountConst;
        public static int triesLeft = triesLeftConst;
        public static int hintsLeft = hintsLeftConst;
        public static int score = scoreConst;
        public static int livesLeft = livesLeftConst;
        public static string[] alphabet = {"A","B","C","D","E","F","G","H","I","J","K",
                "L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        public static string[] marker = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ",
                " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public static string phraseMarker;
        public static string phrase;
        public static string category = categoryConst;
        public static int[] scorePlayer = scorePlayerConst;
        public static string[] namePlayer = namePlayerConst;
        public static string[] nowGuessing = nowGuessingConst;
        public static int guessingPlayer = guessingPlayerConst;
        public static int roundsLeft = roundsLeftConst;
        public static string gameState = "menu"; // "menu", "single", "double"

        public static string[][] image =
        {
                new string[]{
                    "╔═════╗   ",
                    "║     ○   ",
                    "║   / | \\ ",
                    "║    / \\  ",
                    "╚═        "
                },
                new string[]{
                    "╔═════╗   ",
                    "║     ○   ",
                    "║   / | \\ ",
                    "║    /    ",
                    "╚═        "
                },
                new string[]{
                    "╔═════╗   ",
                    "║     ○   ",
                    "║   / | \\ ",
                    "║         ",
                    "╚═        "
                },
                new string[]{
                    "╔═════╗   ",
                    "║     ○   ",
                    "║   / |   ",
                    "║         ",
                    "╚═        "
                },
                new string[]{
                    "╔═════╗   ",
                    "║     ○   ",
                    "║     |   ",
                    "║         ",
                    "╚═        "
                },
                new string[]{
                    "╔═════╗   ",
                    "║     ○   ",
                    "║         ",
                    "║         ",
                    "╚═        "
                },
                new string[]{
                    "╔═════╗   ",
                    "║         ",
                    "║         ",
                    "║         ",
                    "╚═        "
                },
                new string[]{
                    "╔         ",
                    "║         ",
                    "║         ",
                    "║         ",
                    "╚═        "
                },
                new string[]{
                    "          ",
                    "          ",
                    "          ",
                    "          ",
                    "╚═        "
                },
                new string[]{
                    "          ",
                    "          ",
                    "          ",
                    "          ",
                    "          "
                }
         };
    }
}
