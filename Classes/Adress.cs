using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Pages;

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

        public Adress(string streetName, string streetNumber, string city, int zipCode)
        {
            this.StreetNumber = streetNumber;
            this.StreetName = streetName;
            this.City = city;
            this.ZipCode = zipCode;
            Adresser.Add(this);           
        }
        public void DisplayAdress()
        {
            Console.WriteLine("Streetname: {0}", StreetName);
            Console.WriteLine("Streetnumber: {0}", StreetNumber);
            Console.WriteLine("City: {0}", City);
            Console.WriteLine("Zipcode: {0}", ZipCode);

        }
        public void EditAdress()
        {
            Console.WriteLine("Enter your new adress");
            this._streetName = Console.ReadLine();
            Console.WriteLine("Enter your streetnumber");
            this._streetNumber = Console.ReadLine();
            Console.WriteLine("Enter your city");
            this._city = Console.ReadLine();
            Console.WriteLine("Enter your zipcode");
            this._zipCode = Convert.ToInt32(Console.ReadLine());

        }

        public static Adress CreateAdress()
        {
            string streetNumber;
            string streetName;
            string city;
            int zipCode;

            Console.Write("Enter Streetname: ");
            streetName = Console.ReadLine();

            Console.Write("Enter Streetnumber: ");
            streetNumber = Console.ReadLine();

            Console.Write("Enter city: ");
            city = Console.ReadLine();

            while (true)
            {
                Console.Write("Enter Zipcode: ");
                if (int.TryParse(Console.ReadLine(), out zipCode))
                {
                    break;
                }
                
            }

            return new Adress(streetName, streetNumber, city, zipCode);
        }
    }
}
