using System;

namespace LostMyLighter
{
    internal class LighterCasino
    {
        public static void LostOrFoundLighter()
        {
            System.Random rnd = new();
            int lighter = rnd.Next(1, 11);

            switch (lighter)
            {
                case 1:
                    if (PageManager.CurrUser.LighterScore > 0)
                    {
                        RollOne();
                    }
                    else
                    {
                        RollOneZeroLighters();
                    }
                    return;

                case 2:
                case 3:
                case 4:
                case 5:
                    RollTwoToFive();
                    return;

                case 6:
                case 7:
                case 8:
                case 9:
                    RollBetween();
                    return;

                case 10:
                    RollTen();
                    return;
            }
        }

        private static string title = "As you are walking down the street.... ";

        private static void RollOne()
        {
            Page.Header(title);
            PageManager.CurrUser.LighterScore--;
            PageManager.CurrUser.TotalLostLighters--;
            Console.WriteLine("Clumsy! You lost a lighter!\nCurrent lighter Score: {0}", PageManager.CurrUser.LighterScore);
            SymbolPrint.Symbols(3);
            PageManager.PausSleep(4);
        }

        private static void RollOneZeroLighters()
        {
            Page.Header(title);
            PageManager.CurrUser.LighterScore--;
            PageManager.CurrUser.TotalLostLighters--;
            Console.WriteLine("Oh, you just realized that you lost a lighter the other day!\nCurrent lighter Score: {0}", PageManager.CurrUser.LighterScore);
            SymbolPrint.Symbols(3);
            PageManager.PausSleep(4);
        }

        private static void RollTen()
        {
            Page.Header(title);
            PageManager.CurrUser.LighterScore++;
            PageManager.CurrUser.TotalFoundLighters++;
            Console.WriteLine("Lucky! You found a lighter!\nCurrent lighter Score: {0}", PageManager.CurrUser.LighterScore);
            SymbolPrint.Symbols(2);
            PageManager.PausSleep(4);
        }

        private static void RollBetween()
        {
            Page.Header(title);
            Console.WriteLine("What a wonderful day. You managed not to lose your lighter!\nCurrent lighter Score: {0}", PageManager.CurrUser.LighterScore);
            PageManager.PausSleep(4);
        }

        private static void RollTwoToFive()
        {
            Page.Header(title);
            Console.WriteLine("You may not be the best at anything, but atleast you didn't lose a lighter today pal!\nCurrent lighter Score remains at: {0}", PageManager.CurrUser.LighterScore);
            PageManager.PausSleep(4);
        }
    }
}