using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LostMyLighter.Classes.Pages
{
    class MainMenu : Page
    {
        public MainMenu()
        {
            _title = "Main Menu";
            PageManager.AllPages.Add(_title, this);
        }

        public override void LoadPage(out string nextPage)
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
                            nextPage = null;
                            return;
                        case 2:
                            //AddMarschall();
                            nextPage = null;
                            return;
                        case 3:

                            //Add/RemoveLIghter
                            nextPage = null;
                            return;
                        case 4:
                            // ViewProfile();
                            nextPage = "View Profile";
                            return;
                        case 5:
                            // QuitApp();
                            nextPage = null;
                            return;                               
                    }
                }                
            }
        }
    }
}
