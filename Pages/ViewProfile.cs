using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Classes;


namespace LostMyLighter.Pages
{
    class ViewProfile : Page
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
                Console.WriteLine("2. Go Back.");

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
                ErrorMessage();
            }
        }
    }
}
