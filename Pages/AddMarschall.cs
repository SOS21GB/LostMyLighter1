using System;

namespace LostMyLighter
{
    internal class AddMarschall : Page
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
                Marschall.AddMarschall(PageManager.CurrUser);
                SymbolPrint.Line();
                Console.WriteLine("Marschall Added.");
                SymbolPrint.Symbols(1);
                PageManager.PausSleep(2);
                PageManager.CurrUser.NumberOfMarchaller++;
                while (true)
                {
                    Header(_title);
                    Console.WriteLine("1. Add another Marschall");
                    Console.WriteLine("2. Back to Main Menu");
                    SymbolPrint.Line();
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
                    Header(_title);
                    ErrorMessage("Input");
                }
            }
        }
    }
}