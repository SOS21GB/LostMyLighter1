using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LostMyLighter.Classes
{
    class User
    {
        public static Dictionary<int, User> Users = new();

        private int _id;
        private string _password;
        private string _userName;
        private int _age;
        private string _adress;
        private int _numberOfSearches;
        private int _numberOfMarchaller;
        private int _lostLighters;

        /*
        public int Id { get { return _id; } }
        public string UserName { get { return _userName; } set { _userName = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string Adress { get { return _adress; } set { _adress = value; } }
        public int NumberOfSearches { get { return _numberOfSearches; } }
        public int NumberOfMarchaller { get { return _numberOfMarchaller; } }
        */
        public int LostLighters { get { return _lostLighters; } set { _lostLighters = value; } }
        

        public void DisplayUserInfo()
        {


            Console.WriteLine("ID: {0}", _id);
            Console.WriteLine("Name: {0}", _userName);
            Console.WriteLine("Age: {0}", _age);
            Console.WriteLine("Adress: {0}", _adress);
            Console.WriteLine("Searches: {0}", _numberOfSearches);
            Console.WriteLine("Marchallers found: {0}", _numberOfMarchaller);
            Console.WriteLine("Lighters: {0}", _lostLighters);
            Console.WriteLine("------------------------------------------------");
        }

        public void CreatedUserInfo()
        {
            Console.WriteLine("ID: {0}", _id);
            Console.WriteLine("Name: {0}", _userName);
            Console.WriteLine("Age: {0}", _age);
            Console.WriteLine("Adress: {0}", _adress);
            Console.WriteLine("------------------------------------------------");
        }

        public User(string username, int age, string adress, string password)
        {

            this._userName = username;
            this._password = password;  
            this._age = age;
            this._adress = adress;


            _id = Users.Count + 1;
            Users.Add(_id, this);
            CreatedUserInfo();
        }


        



        public bool IsRightPassword(string input)
        {

            return _password == input;
        }
      
        public void EditUser ()
        {
          
            string title = "Edit User";
            PageManager.PageHeader(title);
   
            while (true)
            {
                Console.WriteLine("\n 1. Name \n 2. Age\n 3. Adress \n 4. Found a lighter");
                Console.WriteLine("Please enter the number corresponding to the information you'd like to change: ");
                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Your current username is: {0}", this._userName);
                            Console.WriteLine("Please enter your new username: ");
                            this._userName = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Your current age is: {0}", this._age);
                            Console.WriteLine("Please enter your new age & may i say, happy birthday!: ");

                            while (true)
                            {
                               
                                if (int.TryParse(Console.ReadLine(), out int age))
                                {
                                    Console.WriteLine("Your new age has been changed to: {0}!", age);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong input pal, Try again!");
                                }
                            }

                            break;
                        }
                        
                    case 3:
                        {
                            Console.WriteLine("Your current adress is: {0}", this._adress);
                            Console.WriteLine("Please enter your new adress below: ");
                            this._adress = Console.ReadLine();
                            break;
                        }
                
                    case 4:
                        {

                            while (true)
                            {
                                Console.WriteLine("So you've found a lighter have you? Good work dumdum. \nPlease enter the amount of lighters you've \nfound below my friend: ");
                                if (int.TryParse(Console.ReadLine(), out int lightersfound))
                                {
                                    this._lostLighters += lightersfound;
                                    Console.WriteLine("You have successfully added {0} lighters pal! GJ!",lightersfound);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong input friend,try again!");
                                }      
                            }

                            break;
                        }


                }
                Console.WriteLine("Would you like to change another aspect of your profile? \n Please enter your answer as Y/N below: ");
                char choice2 = Convert.ToChar(Console.ReadLine());
                if (choice2 == 'Y' || choice2 =='y')
                {
                    
                }
                else
                {
                    break;
                }
            }
        }

      
         public void LostLighter()
        {
            string title = "Lost Lighter";
            PageManager.PageHeader(title);
            while (true)
            {

                
                Console.WriteLine("Oh so you lost a lighter now did you dumdum? \nPlease enter the amount of lighters you lost this time below {0}:  ", this._userName);
                
              if (int.TryParse(Console.ReadLine(), out int lighterslost))
                {
                    this._lostLighters -= lighterslost;
                    Console.WriteLine("You have successfully added {0} lighters to the pile of losses my friend. YaY!", lighterslost);
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input, try try again");

                }
            }

        }

        public void RandomLostorFoundLighter()
        {
            Random rnd = new Random();
            int lighter = rnd.Next(1, 11);

            switch (lighter)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Clumsy. You lost a lighter!");
                    this._lostLighters--;
                    PageManager.PausSleep(2);

                    return;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.Clear();
                    Console.WriteLine("What a wonderful day.");
                    PageManager.PausSleep(2);
                    return;

                case 10:
                    Console.Clear();
                    Console.WriteLine("Lucky! You found a lighter!");
                    PageManager.Symbols(2);
                    this._lostLighters++;
                    PageManager.PausSleep(2);
                    return;
            }

        }
        
    }
}
