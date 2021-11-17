using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LostMyLighter.Pages
{
    class StartMenu : Page
    {
        public StartMenu()
        {
            _title = "Lost My Lighter";
        }

        public override void LoadPage(out PageName nextPage)
        {
            while (true)
            {

                //Symbols(1);
                //Symbols(2);
                Header(_title);
                Console.WriteLine("1. Log in");
                Console.WriteLine("2. Create User");
                Console.WriteLine("3. Quit");

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

                Header(_title);
                ErrorMessage();
            }
        }

    }
}
