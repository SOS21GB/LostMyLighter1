using System;

namespace LostMyLighter
{
    internal class ViewProfile : Page
    {
        public ViewProfile()
        {
            _title = "View Profile";
        }

        public override void LoadPage(out PageName nextPage)
        {
            while (true)
            {
                Header(_title);
                PageManager.CurrUser.DisplayUserInfo();
                Console.WriteLine("1. Edit Profile.");
                Console.WriteLine("2. Go Back to Main Menu.");
                SymbolPrint.Line();
                Console.Write("Please enter the number corresponding with what you would like to do: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            nextPage = PageName.EditUser;
                            return;

                        case 2:
                            nextPage = PageName.MainMenu;
                            return;
                    }
                }

                Header(_title);
                ErrorMessage("Number chosen");
            }
        }
    }
}