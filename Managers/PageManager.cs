using LostMyLighter.Pages;
using System;
using System.Collections.Generic;
using System.Threading;

namespace LostMyLighter
{
    internal static class PageManager
    {
        public static User CurrUser;

        public static Dictionary<PageName, Page> AllPages = new()
        {
            { PageName.StartMenu, new StartMenu() },
            { PageName.MainMenu, new MainMenu() },
            { PageName.ViewProfile, new ViewProfile() },
            { PageName.CreateUser, new CreateUser() },
            { PageName.EditUser, new EditUser() },
            { PageName.LogIn, new LogInMenu() },
            { PageName.EditLightersMenu, new EditLightersMenu() },
            { PageName.AddMarschall, new AddMarschall() },
            { PageName.FindMarschalls, new FindMarschalls() },
            { PageName.FoundLighter, new FoundLighter() },
            { PageName.LostLighter, new LostLighter() }
        };

        public static void RunApp()
        {
            PageName nextPage;
            //CurrUser = User.Users[1];

            if (CurrUser != null)
            {
                AllPages[PageName.MainMenu].LoadPage(out nextPage);
            }
            else
            {
                AllPages[PageName.StartMenu].LoadPage(out nextPage);
            }

            while (true)
            {
                if (nextPage != PageName.None)
                {
                    AllPages[nextPage].LoadPage(out nextPage);
                }
                else
                {
                    QuitApp();
                    break;
                }
            }
        }

        public static void LogOut()
        {
            Console.Clear();
            SymbolPrint.Symbols(7);
            Console.WriteLine("Logging out...");
            CurrUser = null;
            PausSleep(3);
        }

        private static void QuitApp()
        {
            Console.Clear();
            SymbolPrint.Symbols(7);
            Console.WriteLine("Exiting App...");
            PausSleep(3);
            Console.Clear();
        }

        public static void PausSleep(int paus)
        {
            Thread.Sleep(TimeSpan.FromSeconds(paus));
            while (Console.KeyAvailable)
            {
                Console.ReadKey(false);
            }
        }
    }
}