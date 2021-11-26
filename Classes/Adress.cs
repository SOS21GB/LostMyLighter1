using System;
using System.Collections.Generic;

namespace LostMyLighter
{
    internal class Adress
    {
        public static List<Adress> Adresser = new();

        public string _streetNumber;
        private string _streetName;
        private string _city;
        private int _zipCode;

        public string StreetNumber
        { get { return _streetNumber; } set { _streetNumber = value; } }

        public string StreetName
        { get { return _streetName; } set { _streetName = value; } }

        public string City
        { get { return _city; } set { _city = value; } }

        public int ZipCode
        { get { return _zipCode; } set { _zipCode = value; } }

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
            Page.Header("Edit Adress");

            Console.Write("Enter your new streetadress: ");
            this._streetName = Console.ReadLine();
            Console.Write("Enter your streetnumber: ");
            this._streetNumber = Console.ReadLine();
            Console.Write("Enter your city: ");
            this._city = Console.ReadLine();
            while (true)
            {
                Console.Write("Enter your zipcode: ");
                if (int.TryParse(Console.ReadLine(), out this._zipCode))
                {
                    break;
                }
                Page.Header("Edit Adress");
                Page.ErrorMessage("Zipcode");
                Page.Header("Edit User");
                Console.Write($"Enter your new streetadress: {_streetName} \n");
                Console.Write($"Enter your streetnumber: {_streetNumber} \n");
                Console.Write($"Enter your city: {_city} \n");
            }
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
                Console.WriteLine("Zipcode not valid...");
            }

            return new Adress(streetName, streetNumber, city, zipCode);
        }
    }
}