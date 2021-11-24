using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Classes;

namespace LostMyLighter.Pages
{
    class FindMarschalls : Page
    {
        public FindMarschalls()
        {
            _title = "Find Marschalls";
        }

        public override void LoadPage(out PageName nextPage)
        {
            while (true)
            {                
                LighterCasino.LostOrFoundLighter();
                Header(_title);
                Marschall.SearchMarschalls();
                PageManager.CurrUser.NumberOfSearches++;
                while (true)                
                {
                    
                    Console.WriteLine("1. Search again");
                    Console.WriteLine("2. Return to Main Menu");
                    SymbolPrint.Line();
                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                nextPage = PageName.FindMarschalls;
                                return;
                            case 2:
                                nextPage = PageName.MainMenu;
                                return;
                        }
                    }
                    Header(_title);
                    ErrorMessage("Input");
                }

            }
        }
    }
}
