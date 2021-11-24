using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Classes;

namespace LostMyLighter.Pages
{
    class LostLighter : EditLightersMenu
    {
        public LostLighter()
        {
            _title = "Lost Lighter";
        }
        public override void LoadPage(out PageName nextPage)
        {


            while (true)
            {
                Header(_title);
                Console.WriteLine("So you went and lost another lighter now did you?\nPlease enter the amount of lighters lost, dumdum: ");
                SymbolPrint.Line();

                if (int.TryParse(Console.ReadLine(), out int lighterslost))
                {
                    Header(_title);
                    PageManager.CurrUser.LostLighters -= lighterslost;
                    Console.WriteLine("{0} lighters have successfully been removed \nLets not do this to a thing bud.", lighterslost);
                    SymbolPrint.Line();
                    Console.WriteLine("Your current lighter score: {0}",PageManager.CurrUser.LostLighters);
                    PageManager.PausSleep(4);
                    nextPage = PageName.EditLightersMenu;
                    return;
                }
                Header(_title);
                ErrorMessage("Wrong input friend,", "try again!");
                PageManager.PausSleep(2);
            }
        }
    }

}
