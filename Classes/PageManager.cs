using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LostMyLighter.Classes
{
    static class PageManager
    {
        public static User CurrUser;

        public static void StartApp()
        {
            if(CurrUser != null)
            {
                MainMenu();
            }
            else
            {
                GuestMenu();
            }       
        }
        
        
        public static void Symbols(int symbol) 
        {
            string marchall = "*****\n" +
                              "*   *\n" +
                              "* * *\n" +
                              "*   *\n" +
                              "*****";
            string lighter = "  _    \n" +
                             " | |  \n" +
                             " | |  \n" +
                             " | |  \n" +
                             " | |  \n" +
                             " | |    )\n" +
                             " | |   .(\n" +
                             " ) | _(, ')\n" +
                             " | o______ |\n" +
                             " |         |\n" +
                             " | ||      |\n" +
                             " | ||      |\n" +
                             " | ||      |\n" +
                             " | || jgs  |\n" +
                             " '---------'";
            switch(symbol)
            {
                case 1:
                    Console.WriteLine(marchall);
                    return;
                case 2:
                    Console.WriteLine(lighter);
                    return;

            }
            
            
        }
        

        /// <summary>
        /// Component to be placed on top of each page, containing the page's title
        /// </summary>
        /// <param name="title"></param>
        public static void PageHeader(string title)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(title);
            Console.WriteLine("------------------------------------------------");
        }

        /// <summary>
        /// Call this method to let the user know that the input was not accepted
        /// </summary>
        static void ErrorMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Input not valid");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        static void GuestMenu()
        {     
            string title = "Welcome";

            while (true)
            {

                PageHeader(title);
                Symbols(1);
                Symbols(2);


                Console.WriteLine("1. Log in");
                Console.WriteLine("2. Create User");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            LogIn();
                            return;
                        case 2:
                            CreateUser();
                            return;
                    }
                }

                PageHeader(title);
                ErrorMessage();
            }
        }


        static void LogIn()
        {
            string title = "Log in";

            while (true)
            {
                PageHeader(title);
                Console.WriteLine("Enter ID: ");
                if (int.TryParse(Console.ReadLine(), out int userid))
                {
                    if (User.Users.ContainsKey(userid))
                    {

                        PageHeader(title);
                        Console.WriteLine("Enter Password: ");
                        string passwordEntered = Console.ReadLine();
                        if (User.Users[userid].IsRightPassword(passwordEntered))
                        {

                            CurrUser = User.Users[userid];
                            Console.WriteLine("Successfully logged in! ");   
                            Thread.Sleep(TimeSpan.FromSeconds(2));
                            MainMenu();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Wrong Password !! ");
                            Thread.Sleep(TimeSpan.FromSeconds(2));
                            LogIn();
                            return;
                        }

                       
                    }
                }
                ErrorMessage();
            }
        }

        static void CreateUser()
        {
            string title = "Create User";
            string password;
            string name;
            int age;
            string adress;

            PageHeader(title);
            Console.Write("Enter Name: ");
            name = Console.ReadLine();            
            
            while (true) 
            {
                Console.Write("Enter Age: ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    break;
                }
                ErrorMessage();
                PageHeader(title);
            }

            Console.Write("Enter Adress: ");
            adress = Console.ReadLine();

            Console.Write("Enter new password: ");
            password = Console.ReadLine();


            PageHeader(title);
            CurrUser = new(name, age, adress, password);

            while (true)
            {
                Console.WriteLine("1. Log In");
                Console.WriteLine("2. Go Back");
                Console.WriteLine("3. Quit App" );

                if(int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            PageHeader(title);
                            Console.WriteLine("Successfully logged in! ");
                            Thread.Sleep(TimeSpan.FromSeconds(2));
                            MainMenu();
                            return;
                        case 2:
                            GuestMenu();
                            return;
                        case 3:
                            QuitApp();
                            return;
                    }
                }
                Console.Clear();
                PageHeader(title);
                ErrorMessage();

                PageHeader(title);
                CurrUser.CreatedUserInfo();
            }
        }

        static void MainMenu()
        {
            string title = "Main Menu";

            while (true)
            {
                PageHeader(title);
                Symbols(1);
                Symbols(2);
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
                            SearchMarschalls();
                            return;
                        case 2:
                            AddMarschall();
                            return;
                        case 3:
                            {
                                 title = "Lighters";
                                while (true)
                                {
                                    PageHeader(title);
                                    Console.WriteLine("Would you like to add a new lighter to your collection or did you lose a lighter idjut?");
                                    Console.WriteLine("1. Add a new lighter \n2. Add a lost lighter");
                                    int.TryParse(Console.ReadLine(), out int choice3);
                                    if (choice3 == 1)
                                    {
                                        Console.WriteLine("Select the amount of lighters you've found: ");
                                        int.TryParse(Console.ReadLine(), out int lightersfound);
                                        CurrUser.LostLighters += lightersfound;
                                       Console.WriteLine("You have successfully added {0} lighters pal! GJ!", lightersfound);
                                        Thread.Sleep(TimeSpan.FromSeconds(2));
                                        break;
                                    }
                                    else if (choice3 == 2)
                                    {
                                        CurrUser.LostLighter();
                                        Thread.Sleep(TimeSpan.FromSeconds(2));
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong input, try again bro!");
                                    }
                                }
                                MainMenu();
                                return;
                            }
                        case 4:
                            ViewProfile();
                            return;
                        case 5:
                            QuitApp();
                            return;
                    }
                }

                PageHeader(title);
                ErrorMessage();
            }
        }

       public static void ViewProfile()
        {
            string title = "Profile";

            while (true)
            {
                PageHeader(title);
                CurrUser.DisplayUserInfo();
                Console.WriteLine("1. Edit Profile.");
                Console.WriteLine("2. Go Back.");

                if(int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            CurrUser.EditUser();
                            ViewProfile();
                            return;
                        case 2:
                            MainMenu();
                            return;
                    }                    
                }

                PageHeader(title);
                ErrorMessage();
            }
        }

        static void SearchMarschalls()
        { 
            string title = "Search";
            PageHeader(title);
            //här lägger vi hela flödet för Search-sidan
        }

        static void AddMarschall()
        {
            string titel = "Add Marschall";
            PageHeader(titel);
            //här lägger vi hela flödet för AddMarschall-sidan
        }

        static void QuitApp()
        {
            Console.Clear();
            Console.WriteLine("*************Logging out******************");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.Clear();
        }
    }
}
