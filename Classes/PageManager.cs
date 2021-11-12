using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /// <summary>
        /// Component to be placed on top of each page, containing the page's title
        /// </summary>
        /// <param name="title"></param>
        static void PageHeader(string title)
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
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        static void GuestMenu()
        {     
            string titel = "Welcome";

            while (true)
            {
                PageHeader(titel);

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

                PageHeader(titel);
                ErrorMessage();
            }
          

        }


        static void LogIn()
        {
            string titel = "Log in";
            PageHeader(titel);
            //här lägger vi flödet för inlogg
        }

        static void CreateUser()
        {
            string titel = "Create User";
            string name;
            int age;
            string adress;
            PageHeader(titel);

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
                PageHeader(titel);
            }

            Console.Write("Enter Adress: ");
            adress = Console.ReadLine();
            PageHeader(titel);
            User newUser = new(name, age, adress);         

        }

        static void MainMenu()
        {
            string title = "Main Menu";

            while (true)
            {
                PageHeader(title);
                Console.WriteLine();
                Console.WriteLine("1. Find marschalls.");
                Console.WriteLine("2. Add marschall.");
                Console.WriteLine("3. View profile.");
                Console.WriteLine("4. Quit.");
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
                            ViewProfile();
                            return;
                        case 4:
                            QuitApp();
                            return;
                    }
                }

                PageHeader(title);
                ErrorMessage();
            }

        }

        static void ViewProfile()
        {
            string titel = "Profile";
            PageHeader(titel);

        }

        static void SearchMarschalls()
        { 
            string titel = "Search";
            PageHeader(titel);
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
            
        }
    }
}
