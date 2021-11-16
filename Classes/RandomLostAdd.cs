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
            System.Random rnd = new System.Random();
            int lighter = rnd.Next(1, 11);

            switch (lighter)
            {
                case 1:
                    RollOne();
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

        public static void RollOne()
        {
            Console.Clear();
            Console.WriteLine("Clumsy. You lost a lighter!");
            PageManager.CurrUser.LostLighters--;
            PageManager.Symbols(3);
            PageManager.PausSleep(2);
        }

        public static void RollTen()
        {
            Console.Clear();
            Console.WriteLine("Lucky! You found a lighter!");
            PageManager.Symbols(2);
            PageManager.CurrUser.LostLighters++;
            PageManager.PausSleep(2);
        }

        public static void RollBetween()
        {
            Console.Clear();
            Console.WriteLine("What a wonderful day.");
            PageManager.PausSleep(2);
        }
    }
    
}
