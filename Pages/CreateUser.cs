using System;

namespace LostMyLighter
{
    internal class CreateUser : Page
    {
        public CreateUser()
        {
            _title = "Create User";
        }

        public override void LoadPage(out PageName nextPage)
        {
            while (true)
            {
                Header(_title);
                string name;
                string password;
                int age;
                Adress adress;

                Console.Write("Enter Name: ");
                name = Console.ReadLine();

                while (true)
                {
                    Console.Write("Enter Age: ");
                    if (int.TryParse(Console.ReadLine(), out age))
                    {
                        break;
                    }
                    ErrorMessage("Entered age");
                }

                adress = Adress.CreateAdress();

                Console.Write("Password for new user: ");
                password = Console.ReadLine();

                User user = new User(name, age, adress, password);

                Header("Created User");
                user.CreatedUserInfo();
                Console.WriteLine("1. Log in created User");
                Console.WriteLine("2. Back to Start Menu");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            PageManager.CurrUser = user;
                            nextPage = PageName.MainMenu;
                            return;

                        case 2:
                            nextPage = PageName.StartMenu;
                            return;
                    }
                }
                Header(_title);
                ErrorMessage("Number chosen");
            }
        }
    }
}