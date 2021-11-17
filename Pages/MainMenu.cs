using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LostMyLighter.Pages
{
    class MainMenu : Page
    {
        public MainMenu()
        {
            _title = "Main Menu";
        }

        public override void LoadPage(out PageName nextPage)
        {
            while (true)
            {
                Header(_title);
                //Symbols(1);
                //Symbols(2);
                Console.WriteLine();
                Console.WriteLine("1. Find marschalls.");
                Console.WriteLine("2. Add marschall.");
                Console.WriteLine("3. Add a lost/found lighter.");
                Console.WriteLine("4. View profile.");
                Console.WriteLine("5. Quit.");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------");

                if (int.TryParse(Console.ReadLine(), out int userInput))
                {
                    switch (userInput)
                    {
                        case 1:
                            //SearchMarschalls();
                            nextPage = PageName.FindMarschalls;
                            return;
                        case 2:
                            //AddMarschall();
                            nextPage = PageName.AddMarschall;
                            return;
                        case 3:

                            //Add/RemoveLIghter
                            nextPage = PageName.AddRemoveLighter;
                            return;
                        case 4:
                            // ViewProfile();
                            nextPage = PageName.ViewProfile;
                            return;
                        case 5:
                            // QuitApp();
                            nextPage = PageName.None;
                            return;                               
                    }
                }                
            }
        }
    }
}
