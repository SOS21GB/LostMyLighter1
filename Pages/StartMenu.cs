using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Classes;



namespace LostMyLighter.Pages
{
    class StartMenu : Page
    {
        public StartMenu()
        {
            _title = "Welcome to Lighters, Marshals and Cigarettes";
        }

        public override void LoadPage(out PageName nextPage)
        {
            while (true)
            {
                Console.Clear();
                SymbolPrint.Symbols(4);
                SymbolPrint.Symbols(6);
                SymbolPrint.Symbols(5);
                Console.WriteLine("1. Log in");
                Console.WriteLine("2. Create User");
                Console.WriteLine("3. Quit");
                SymbolPrint.Line();

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            nextPage = PageName.LogIn;
                            return;
                        case 2:
                            nextPage = PageName.CreateUser;
                            return;
                        case 3:
                            nextPage = PageName.None;
                            return;
                    }
                }

                Console.Clear();
                SymbolPrint.Symbols(4);
                SymbolPrint.Symbols(6);
                SymbolPrint.Symbols(5);
                ErrorMessage("Number chosen");
            }
        }

    }
}
