using System;
namespace hangMan
{
    public class Loops
    {
        public static void SingleGameLoop()
        {
            while (!EndGame.SingleEndGame())
            {
                Draw.DrawSingleGame();
                UserInput.userInput();
                CheckLetter.checkLetter();
                if (EndGame.wonGame()) {gameOutcome(0, " The man lives!", "", Draw.DrawSingleGame);}
                if (EndGame.lostGame()) {gameOutcome(-1, " You let the man hang...", " The phrase was: " + Globals.phrase, Draw.DrawSingleGame);}
            }
        }

        public static void DoubleGameLoop()
        {
            while (!EndGame.DoubleEndGame())
            {
                Player.guessingPlayer();
                Draw.DrawDoubleGame();
                UserInput.userInput();
                CheckLetter.checkLetter();
                if (EndGame.wonGame()) { gameOutcome(-1, " The man lives!", "", Draw.DrawDoubleGame); }
                if (EndGame.lostGame()) { gameOutcome(-1, " You let the man hang...", " The phrase was: " + Globals.phrase, Draw.DrawDoubleGame); }
            }
        }

        public static void MenuLoop()
        {
            Draw.drawHangMan();
            Menu.Handler(Console.ReadLine());
            CheckLetter.checkLetter();
        }

        public static void gameOutcome(int live, string hang, string phrase, Action drawGame)
        {

            if(Globals.gameState == "single")
            {
                drawGame();
                Console.WriteLine("");
                Console.WriteLine(hang);
                if (phrase != "") { Console.WriteLine(phrase); }
                if (EndGame.wonGame()){Globals.score = Globals.score + Score.calcScore();}
                Lives.UpdateLives(live);
                Console.WriteLine(" Press any button to continue...");
                Console.Write(" ");
                Console.ReadKey();
                Library.GetPhrase();
                UpdateTable.restartTable();
                CheckLetter.checkLetter();
            }

            if(Globals.gameState == "double")
            {
                
                drawGame();
                Console.WriteLine("");
                Console.WriteLine(hang);
                if (phrase != "") { Console.WriteLine(phrase); }
                if (Globals.roundsLeft > 1)
                {
                    Draw.doubleGameInput();
                    if (Console.ReadLine().ToLower() == "i") { PhraseInput.GetPhrase(); Library.GetCategory(Library.list.Length + 1); }
                    else { Library.GetPhrase(); }
                }
                if (EndGame.wonGame())
                {
                    Globals.scorePlayer[Globals.guessingPlayer] = Globals.scorePlayer[Globals.guessingPlayer] + Score.calcScore();
                }
                Lives.UpdateRounds(live);
                UpdateTable.restartTable();
                CheckLetter.checkLetter();
            }
        }
    }
}
