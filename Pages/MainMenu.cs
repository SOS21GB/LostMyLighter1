using LostMyLighter.Classes;
using System;

namespace LostMyLighter.Pages
{
    internal class MainMenu : Page
    {
        public MainMenu()
        {
            _title = "Main Menu";
        }

        public override void LoadPage(out PageName nextPage)
        {
            while (true)
            {
                Header(_title);
                Console.WriteLine("1. Find marschalls.");
                Console.WriteLine("2. Add marschall.");
                Console.WriteLine("3. Add a lost/found lighter.");
                Console.WriteLine("4. View profile.");
                Console.WriteLine("5. Log Out");
                Console.WriteLine("6. Quit App.");
                SymbolPrint.Line();
                Console.Write("Please enter the number corresponding with what you would like to do: ");

                if (int.TryParse(Console.ReadLine(), out int userInput))
                {
                    switch (userInput)
                    {
                        case 1:
                            //SearchMarschalls();
                            nextPage = PageName.FindMarschalls;
                            return;

                        case 2:
                            //AddMarschall();
                            nextPage = PageName.AddMarschall;
                            return;

                        case 3:

                            //Add/RemoveLIghter
                            nextPage = PageName.EditLightersMenu;
                            return;

                        case 4:
                            // ViewProfile();
                            nextPage = PageName.ViewProfile;
                            return;

                        case 5:

                            nextPage = PageName.StartMenu;
                            PageManager.LogOut();

                            return;

                        case 6:
                            // QuitApp();
                            nextPage = PageName.None;
                            PageManager.LogOut();
                            return;
                    }
                }

                Header(_title);
                ErrorMessage("Number chosen");
            }
        }
    }
}