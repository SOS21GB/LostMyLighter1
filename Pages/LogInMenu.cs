using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Classes;

namespace LostMyLighter.Pages
{
    class LogInMenu : Page
    {
        public LogInMenu()
        {
            _title = "Log In";
        }

        public override void LoadPage(out PageName nextPage)
        {
            while (true)
            {
                Header(_title);
                Console.WriteLine("Enter ID: ");

                if (int.TryParse(Console.ReadLine(), out int userid))
                {
                    if (User.Users.ContainsKey(userid))
                    {
                        Header(_title);
                        Console.WriteLine("Enter Password: ");
                        string passwordEntered = Console.ReadLine();

                        if (User.Users[userid].IsRightPassword(passwordEntered))
                        {
                            PageManager.CurrUser = User.Users[userid];
                            Header(_title);
                            Console.WriteLine("Successfully logged in! ");
                            PageManager.PausSleep(2);
                            nextPage = PageName.MainMenu;
                            return;
                        }
                        else
                        {
                            Header(_title);
                            Console.WriteLine("Password", "Incorrect");   
                        }
                    }

                    else
                    {
                        Header(_title);
                        Console.WriteLine("ID", "not registered");               
                    }

                    //detta sker om användaren har fel id eller lösen
                    PageManager.PausSleep(2);
                }
                else
                {
                    //om inmatningen av id inte enbart är siffror
                    Header(_title);
                    ErrorMessage("Entered ID");
                    PageManager.PausSleep(2);

                }

        }   }
    }
}
