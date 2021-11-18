using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Pages;


namespace LostMyLighter.Classes
{
    class LighterCasino
    {
        public static void LostOrFoundLighter()
        {
            System.Random rnd = new();
            int lighter = rnd.Next(1, 11);

            switch (lighter)
            {
                case 1:
                    if (PageManager.CurrUser.LostLighters > 0)
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

        static string title = "On the streets.";
        static void RollOne()
        {
            Page.Header(title);
            Console.WriteLine("Clumsy! You lost a lighter!");
            PageManager.CurrUser.LostLighters--;
            SymbolPrint.Symbols(3);
            PageManager.PausSleep(2);
        }

        static void RollOneZeroLighters()
        {
            Page.Header(title);
            Console.WriteLine("You just realized that you lost a lighter the other day!");
            PageManager.CurrUser.LostLighters--;
            SymbolPrint.Symbols(3);
            PageManager.PausSleep(2);
        }

        static void RollTen()
        {
            Page.Header(title);
            Console.WriteLine("Lucky! You found a lighter!");
            SymbolPrint.Symbols(2);
            PageManager.CurrUser.LostLighters++;
            PageManager.PausSleep(2);
        }

        static void RollBetween()
        {
            Page.Header(title);
            Console.WriteLine("What a wonderful day. You managed not to lose your lighter!");
            PageManager.PausSleep(2);
        }
    }
    
}
