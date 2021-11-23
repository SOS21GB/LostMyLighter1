using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Classes;

namespace LostMyLighter.Pages
{
    class EditUser : Page
    {
        public EditUser()
        {
            _title = "Edit User";
        }

        public override void LoadPage(out PageName nextPage)
        {
            
            while (true)
            {
                Header(_title);
                PageManager.CurrUser.EditUserInfo();
                Console.WriteLine("1. Name \n2. Age\n3. Adress \n4. Return to Main Menu");
                SymbolPrint.Line();
                Console.Write("Please enter the number corresponding to the information you'd like to change: ");
                
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            PageManager.CurrUser.EditName();
                            break;
                        case 2:
                            PageManager.CurrUser.EditAge();
                            break;
                        case 3:
                            PageManager.CurrUser.UserAdress.EditAdress();
                            break;
                        case 4:
                            nextPage = PageName.MainMenu;
                            return;

                    }
                }
                else
                {
                    Header(_title);
                    ErrorMessage("Number chosen");
                }
            }
        }
    }
}
