using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using LostMyLighter.Pages;


namespace LostMyLighter.Classes
{
    static class PageManager
    {
        public static User CurrUser;

        public static Marschall CurrMarschall;

        public static Dictionary<PageName, Page> AllPages = new()
        {
            { PageName.StartMenu, new StartMenu() },
            { PageName.MainMenu, new MainMenu() },
            { PageName.ViewProfile, new ViewProfile() },
            { PageName.CreateUser, new CreateUser() },
            { PageName.EditUser, new EditUser() },
            { PageName.LogIn, new LogInMenu() },
            { PageName.AddRemoveLighter, new EditLightersMenu() },
            { PageName.AddMarschall, new AddMarschall() },
            { PageName.FindMarschalls, new FindMarschalls() }

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
            SymbolPrint.Symbols(5);
            Console.WriteLine("Logging out...");
            CurrUser = null;
            PausSleep(3);
        }

        static void QuitApp()
        {
            Console.Clear();
            SymbolPrint.Symbols(5);
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
