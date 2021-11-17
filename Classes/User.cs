﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighter.Classes
{
    class User
    {
        public static Dictionary<int, User> Users = new();

        private int _id;
        private string _userName;
        private int _age; 
        private Adress _adress;
        private int _numberOfSearches;
        private int _numberOfMarchaller;
        private int _lostLighters;
        
        public int Id { get { return _id; } }
        public string UserName { get { return _userName; } set { _userName = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public Adress UserAdress { get { return _adress; } set { _adress = value; } }
        public int NumberOfSearches { get { return _numberOfSearches; } }
        public int NumberOfMarchaller { get { return _numberOfMarchaller; } }
        public int LostLighters { get { return _lostLighters; } set { _lostLighters = value; } }

        public void DisplayUserInfo()
        {

            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Name: {0}", UserName);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Adress: {0}", UserAdress);
            Console.WriteLine("Searches: {0}", NumberOfSearches);
            Console.WriteLine("Marchallers found: {0}", NumberOfMarchaller);
            Console.WriteLine("Lost Lighters: {0}", LostLighters);
            Console.WriteLine("------------------------------------------------");
        }

        public void CreatedUserInfo()
        {
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Name: {0}", UserName);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Adress: {0}", UserAdress);
            Console.WriteLine("------------------------------------------------");
        }

        public User(string username, int age, Adress adress)
        {
            this.UserName = username;
            this.Age = age;
            this.UserAdress = adress;
            _id = Users.Count + 1;
            Users.Add(_id, this);
            CreatedUserInfo();
        }
      
        public void EditUser ()
        {
            
            Console.WriteLine("-------------------- Edit User--------------------");
            Console.WriteLine(" ------------------------------------------------ ");
            Console.WriteLine("You may now choose to change the following information\n 1. Name \n 2. Age\n 3. Adress \n 4. Found a lighter");
            Console.WriteLine("Please enter the number corresponding to the action you would like to take: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Your current username is: {0}", this.UserName);
                            Console.WriteLine("Please enter your new username: ");
                            this.UserName = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Your current age is: {0}", this.Age);
                            Console.WriteLine("Please enter your new age & may i say, happy birthday!: ");
                            this.Age = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Your current adress is: {0}", this.UserAdress);
                            Console.WriteLine("Please enter your new adress below: ");
                            //this.UserAdress = Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("So you've found a lighter have you? Good work dumdum. \n Please enter the amount of lighters you've \n found below my friend: ");
                            this.LostLighters += Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("Oh so you lost a lighter now did you dumdum? \n Please enter the amount of lighters you lost this time below {0}:  ", this.UserName);
            int lightersLost = Convert.ToInt32(Console.ReadLine());
            this.LostLighters -= lightersLost;
            Console.WriteLine("You have successfully added {0} lighters to the pile of losses my friend. YaY!",lightersLost);
        }
    }
}
