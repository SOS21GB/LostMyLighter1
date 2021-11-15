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
        private string _userName;
        private int _age;
        private string _adress;
        private int _numberOfSearches;
        private int _numberOfMarchaller;
        private int _lostLighters;

        /*
        public int _id { get { return _id; } }
        public string _userName { get { return _userName; } set { _userName = value; } }
        public int _age { get { return _age; } set { _age = value; } }
        public string _adress { get { return _adress; } set { _adress = value; } }
        public int _numberOfSearches { get { return _numberOfSearches; } }
        public int _numberOfMarchaller { get { return _numberOfMarchaller; } }
        public int _lostLighters { get { return _lostLighters; } set { _lostLighters = value; } }
        */

        public void DisplayUserInfo()
        {

            Console.WriteLine("ID: {0}", _id);
            Console.WriteLine("Name: {0}", _userName);
            Console.WriteLine("Age: {0}", _age);
            Console.WriteLine("Adress: {0}", _adress);
            Console.WriteLine("Searches: {0}", _numberOfSearches);
            Console.WriteLine("Marchallers found: {0}", _numberOfMarchaller);
            Console.WriteLine("Lost Lighters: {0}", _lostLighters);
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

        public User(string username, int age, string adress)
        {
            this._userName = username;
            this._age = age;
            this._adress = adress;
            _id = Users.Count + 1;
            Users.Add(_id, this);
            CreatedUserInfo();
        }
        static string title = "Edit User";
        public void EditUser()
        {


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
                            this._age = Convert.ToInt32(Console.ReadLine());
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
                            Console.WriteLine("So you've found a lighter have you? Good work dumdum. \n Please enter the amount of lighters you've \n found below my friend: ");
                            this._lostLighters += Convert.ToInt32(Console.ReadLine());
                            break;
                        }


                }
                Console.WriteLine("Would you like to change another aspect of your profile? \n Please enter your answer as Y/N below: ");
                char choice2 = Convert.ToChar(Console.ReadLine());
                if (choice2 == 'Y')
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
            while (true)
            {
                Console.WriteLine("Oh so you lost a lighter now did you dumdum? \n Please enter the amount of lighters you lost this time below {0}:  ", this._userName);
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
                    Thread.Sleep(TimeSpan.FromSeconds(2));
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
                    return;

                case 10:
                    Console.Clear();
                    Console.WriteLine("Lucky! You found a lighter!");
                    PageManager.Symbols(2);
                    this._lostLighters++;
                    return;
            }

        }
        
    }
}
