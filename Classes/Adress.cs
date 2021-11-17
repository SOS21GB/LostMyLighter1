using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighter.Classes
{
    class Adress
    {
         public static List< Adress> Adresser = new();

        public string _streetNumber;
        private string _streetName;
        private string _city;
        private int _zipCode; 

        public string StreetNumber { get { return _streetNumber; } set {_streetNumber = value; } }
        public string StreetName { get { return _streetName; } set {_streetName = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public int ZipCode { get { return _zipCode; } set { _zipCode = value; } }

        public Adress(string streetName, string city, int zipCode, string streetNumber)
        {
            this.StreetNumber = streetNumber;
            this.StreetName = streetName;
            this.City = city;
            this.ZipCode = zipCode;
            Adresser.Add(this);           
        }
    }
}
