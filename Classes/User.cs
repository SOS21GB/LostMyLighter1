using System;
using System.Collections.Generic;

namespace LostMyLighter
{
    internal class User
    {
        public static Dictionary<int, User> Users = new();

        private int _id;
        private string _password;
        private string _userName;
        private int _age;
        private Adress _adress;
        private int _numberOfSearches;
        private int _numberOfMarchaller;
        private int _lighterScore;
        private int _totalLostLighters;
        private int _totalFoundLighters;

        /*
        public int Id { get { return _id; } }

        public int Age { get { return _age; } set { _age = value; } }
        public Adress UserAdress { get { return _adress; } set { _adress = value; } }
        */

        public string UserName
        { get { return _userName; } }

        public Adress UserAdress
        { get { return _adress; } }

        public int NumberOfSearches
        { get { return _numberOfSearches; } set { _numberOfSearches = value; } }

        public int NumberOfMarchaller
        { get { return _numberOfMarchaller; } set { _numberOfMarchaller = value; } }

        public int LighterScore
        { get { return _lighterScore; } set { _lighterScore = value; } }

        public int TotalLostLighters
        { get { return _totalLostLighters; } set { _totalLostLighters = value; } }

        public int TotalFoundLighters
        { get { return _totalFoundLighters; } set { _totalFoundLighters = value; } }

        public User(string username, int age, Adress adress, string password)
        {
            this._userName = username;
            this._password = password;
            this._age = age;
            this._adress = adress;

            _id = Users.Count + 1;
            Users.Add(_id, this);
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine("ID: {0}", _id);
            Console.WriteLine("Name: {0}", _userName);
            Console.WriteLine("Age: {0}", _age);
            this._adress.DisplayAdress();
            Console.WriteLine("Searches: {0}", _numberOfSearches);
            Console.WriteLine("Marchallers added: {0}", _numberOfMarchaller);
            Console.WriteLine("Current lighter score: {0}. Total lighters found: {1}. Total lighters lost: {2}", _lighterScore, _totalFoundLighters, _totalLostLighters);
            SymbolPrint.Line();
        }

        public void CreatedUserInfo()
        {
            Console.WriteLine("Login ID: {0}", _id);
            Console.WriteLine("Name: {0}", _userName);
            Console.WriteLine("Age: {0}", _age);
            this._adress.DisplayAdress();
            SymbolPrint.Line();
        }

        public void LighterStats()
        {
            Console.WriteLine("Current lighter score: {0}. Total lighters found: {1}. Total lighters lost: {2}.", _lighterScore, _totalFoundLighters, _totalLostLighters);
        }

        public void EditUserInfo()
        {
            Console.WriteLine("Name: {0}", _userName);
            Console.WriteLine("Age: {0}", _age);
            this._adress.DisplayAdress();
            SymbolPrint.Line();
        }

        public bool IsRightPassword(string input)
        {
            return _password == input;
        }

        public void EditName()
        {
            Console.WriteLine("Your current username is: {0}", this._userName);
            Console.WriteLine("Please enter your new username: ");
            this._userName = Console.ReadLine();
        }

        public void EditAge()
        {
            Console.WriteLine("Your current age is: {0}", this._age);
            Console.WriteLine("Please enter your new age & may I say, happy birthday!: ");
            if (int.TryParse(Console.ReadLine(), out this._age))
            {
                Console.WriteLine("Your new age has been changed to: {0}!", this._age);
            }
            else
            {
                Console.WriteLine("Wrong input pal, Try again!");
                PageManager.PausSleep(1);
            }
        }
    }
}