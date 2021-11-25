using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Classes;

namespace LostMyLighter.Pages
{
    class EditLightersMenu : Page
    {
        public EditLightersMenu()
        {
            _title = "Add or Remove Lighters";
        }

        public override void LoadPage(out PageName nextPage)
        {


            while (true)
            {
                Header(_title);
                Console.WriteLine("1. Found a Lighter");
                Console.WriteLine("2. Lost a Lighter");
                Console.WriteLine("3. Lighter Statistics");
                Console.WriteLine("4. Back to Main Menu");
                SymbolPrint.Line();
                Console.Write("Please choose an action to take:");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            nextPage = PageName.FoundLighter;
                            return;
                        case 2:
                            nextPage = PageName.LostLighter;
                            return;
                        case 3:
                            PageManager.CurrUser.LighterStats();
                            PageManager.PausSleep(4);
                            nextPage = PageName.EditLightersMenu;
                            return;
                        case 4:
                            nextPage = PageName.MainMenu;
                            return;
                    }
                }
                
                Header(_title);
                ErrorMessage("Input");
                PageManager.PausSleep(2);
            }

        }

    }
}
