using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighter.Classes
{
    class User
    {
        int _id;
        string _userName;
        int _age;
        string _adress;
        int _numberOfSearchers;
        int _numberOfMarchaller;
        int _lostLighters;
        
        public int Id { get { return _id; } }
        public string UserName { get { return _userName; } }
        public int Age { get { return _age; } }
        public string Adress { get { return _adress; } }
        public int NumberOfSearchers { get { return _numberOfSearchers; } }
        public int NumberOfMarchaller { get { return _numberOfMarchaller; } }
        public int LostLighters { get { return _lostLighters; } }

        public User()
        {

        }
    }
}
