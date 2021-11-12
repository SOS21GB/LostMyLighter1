using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighter.Classes
{
    class Adress
    {
         public static Dictionary<int, Adress> Adress = new();

        private string _streetName;
        private string _place;
        private int _zipCode; 

        public string StreetName { get { return _streetName; } }
        public string Place { get { return _userName; } set { _place = value; } }
        public int ZipCode { get { return _age; } set { _zipCode = value; } }

        public Adress(string streetName, string place, int zipCode)
        {
            this.StreetName = streetName;
            this.Place = place;
            this.ZipCode = zipCode;
            Adress.Add(_streetName, this);
            
        }
    }
}
