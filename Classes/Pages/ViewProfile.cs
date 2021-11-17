using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighter.Classes.Pages
{
    class ViewProfile : Page
    {

        public override void LoadPage(out string nextPage)
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
                            //PageManager.CurrUser.EditUser();
                            nextPage = null;
                            return;
                        case 2:
                            nextPage = "Main Menu";
                            return;
                    }
                }

             
            }
        }

        public ViewProfile()
        {
            _title = "View Profile";
            PageManager.AllPages.Add(_title, this);
        }
    }
}
