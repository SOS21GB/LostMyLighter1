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
            _title = "Add/Remove Lighters";
        }

        public override void LoadPage(out PageName nextPage)
        {

           
            while (true)
            {
                Header(_title);
                Console.WriteLine("So you've found a lighter have you? Good work dumdum. \nPlease enter the amount of lighters you've \nfound below my friend: ");
                
                if (int.TryParse(Console.ReadLine(), out int lightersfound))
                {
                    PageManager.CurrUser.LostLighters += lightersfound;
                    Console.WriteLine("You have successfully added {0} lighters pal! GJ!", lightersfound);
                    nextPage = PageName.MainMenu;
                    return;
                }
                ErrorMessage("Wrong input friend,try again!");



            }
           
        }

    }
}
