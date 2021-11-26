using LostMyLighter.Classes;
using System;

namespace LostMyLighter.Pages

{
    internal class FoundLighter : Page
    {
        public FoundLighter()
        {
            _title = " Found Lighter";
        }

        public override void LoadPage(out PageName nextPage)
        {
            while (true)

            {
                Header(_title);
                Console.WriteLine("So you've found a lighter have you? Good work dumdum. \nPlease enter the amount of lighters you've \nfound below my friend: ");
                SymbolPrint.Line();
                if (int.TryParse(Console.ReadLine(), out int lightersfound))
                {
                    {
                        Header(_title);
                        PageManager.CurrUser.LighterScore += lightersfound;
                        PageManager.CurrUser.TotalFoundLighters += lightersfound;
                        Console.WriteLine("You have successfully added {0} lighters pal! Hope to see you soon!", lightersfound);
                        SymbolPrint.Line();
                        Console.WriteLine("Your current lighter score: {0}", PageManager.CurrUser.LighterScore);
                        PageManager.PausSleep(4);
                        nextPage = PageName.EditLightersMenu;
                        return;
                    }
                }
                Header(_title);
                ErrorMessage("Wrong input friend,", "try again!");
            }
        }
    }
}