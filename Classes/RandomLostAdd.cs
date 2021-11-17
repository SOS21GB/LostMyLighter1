using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LostMyLighter.Classes
{
    class RandomLostAdd
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
        public static void RollOne()
        {
            PageManager.PageHeader(title);
            Console.WriteLine("Clumsy! You lost a lighter!");
            PageManager.CurrUser.LostLighters--;
            SymbolPrint.Symbols(3);
            PageManager.PausSleep(2);
        }

        public static void RollOneZeroLighters()
        {
            PageManager.PageHeader(title);
            Console.WriteLine("You just realized that you lost a lighter the other day!");
            PageManager.CurrUser.LostLighters--;
            SymbolPrint.Symbols(3);
            PageManager.PausSleep(2);
        }

        public static void RollTen()
        {
            PageManager.PageHeader(title);
            Console.WriteLine("Lucky! You found a lighter!");
            SymbolPrint.Symbols(2);
            PageManager.CurrUser.LostLighters++;
            PageManager.PausSleep(2);
        }

        public static void RollBetween()
        {
            PageManager.PageHeader(title);
            Console.WriteLine("What a wonderful day.");
            PageManager.PausSleep(2);
        }
    }
    
}
