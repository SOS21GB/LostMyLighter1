using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Classes;

namespace LostMyLighter.Pages
{
    class AddMarschall : Page
    {
        public AddMarschall()
        {
            _title = "Add Marschall";
        }

        public override void LoadPage(out PageName nextPage)
        {
            while (true)
            {
                Header(_title);
                Marschall.AddMarschall();
                Console.WriteLine("Marschall Added.");
                SymbolPrint.Line();
                PageManager.CurrUser.NumberOfMarchaller++;
                Console.WriteLine("1. Add another Marschall");
                Console.WriteLine("2. Back to Main Menu");                
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            nextPage = PageName.AddMarschall;
                            return;
                        case 2:
                            nextPage = PageName.MainMenu;
                            return;
                    }
                }

            }

        }
    }
}
