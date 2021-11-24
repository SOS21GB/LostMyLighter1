using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Classes;


namespace LostMyLighter.Pages
{
    class MainMenu : Page
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
