using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighter.Classes.Pages
{
    class StartMenu : Page
    {
        public StartMenu()
        {
            _title = "Lost My Lighter";
            PageManager.AllPages.Add(_title, this);
        }

        public override void LoadPage(out string nextPage)
        {
            while (true)
            {

                Header(_title);
                //Symbols(1);
                //Symbols(2);


                Console.WriteLine("1. Log in");
                Console.WriteLine("2. Create User");
                Console.WriteLine("3. Quit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            nextPage = "LogIn";
                            return;
                        case 2:
                            nextPage = null;
                            return;
                        case 3:
                            nextPage = null;
                            return;
                    }
                }
            }
        }

    }
}
