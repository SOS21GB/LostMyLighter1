using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighter.Classes
{
    class User
    {
        private int _id;
        private string _userName;
        private int _age; 
        private string _adress;
        private int _numberOfSearches;
        private int _numberOfMarchaller;
        private int _lostLighters;
        
        public int Id { get { return _id; } }
        public string UserName { get { return _userName; } set { _userName = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string Adress { get { return _adress; } set { _adress = value; } }
        public int NumberOfSearches { get { return _numberOfSearches; } }
        public int NumberOfMarchaller { get { return _numberOfMarchaller; } }
        public int LostLighters { get { return _lostLighters; } }

        public void DisplayUserInfo()
        {
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Name: {0}", UserName);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Adress: {0}", Adress);
            Console.WriteLine("Searches: {0}", NumberOfSearches);
            Console.WriteLine("Marchallers found {0}", NumberOfMarchaller);
            Console.WriteLine("Lost Lighters: {0}", LostLighters);

        }

        public User()
        {

        }

        public User(string username, int age, string adress)
        {
            this.UserName = username;
            this.Age = age;
            this.Adress = adress;
        }

    }
}
