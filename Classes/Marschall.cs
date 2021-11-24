
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Pages;

namespace LostMyLighter.Classes
{
    class Marschall
    {
        public static List<Marschall> Marschalls = new List<Marschall>();
        private User _user;
        private string _brand;
        private int _burnTime;
        private DateTime _timeRegistered;
        private DateTime _expectedBurnOutTime;
        private Adress _marschallAdress;
        private int _IdMarschall;
        public string Brand { get { return _brand; } }
        public int BurnTime { get { return _burnTime;} }

        public Marschall(User user, string brand, int burnTime, Adress adress)
        {
            this._user = user;
            this._brand = brand;
            this._burnTime = burnTime;
            this._timeRegistered = DateTime.Now;
            this._expectedBurnOutTime = _timeRegistered.AddHours(BurnTime);
            this._marschallAdress = adress;


            _IdMarschall = Marschalls.Count + 1;

            Marschalls.Add(this);

        }

        public Marschall(User user, string brand, int burnTime, int hoursSinceRegistrerd, Adress adress)
        {
            this._user = user;
            this._brand = brand;
            this._burnTime = burnTime;
            this._timeRegistered = DateTime.Now.AddHours(-hoursSinceRegistrerd);
            this. _expectedBurnOutTime = _timeRegistered.AddHours(BurnTime);
            this._marschallAdress = adress;


            _IdMarschall = Marschalls.Count + 1;

            Marschalls.Add(this);

        }

        public static void DisplayAllMarschaller()
        {
             string title = "All Marschall";

            foreach (var m in Marschalls)
            {
                m.DisplayMarsachall();

            }
        }


        public static void SearchMarschalls()
        {
            Console.WriteLine("Choose how to Search: ");
            Console.WriteLine("\n1. Brand");
            Console.WriteLine("2. Zip Code");
            Console.WriteLine("3. Street Name");
            Console.WriteLine("4. City");
            Console.WriteLine("5. See all Active");
            Console.WriteLine("6. See All");
            SymbolPrint.Line();

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Page.Header("Find Marschalls");
                    Console.WriteLine("Enter Brand:");
                    string brandInput = Console.ReadLine();
                    var BrandList = Marschalls.Where(item => item._brand == brandInput);
                    
                    foreach (var item in BrandList)
                    {
                        Console.WriteLine("Resultat: {0}", item._brand);
                    }
                    SymbolPrint.Line();
                    break;
                case 2:
                    Page.Header("Find Marschalls");
                    Console.WriteLine("Enter ZipCode:");
                    int zipInput = Convert.ToInt32(Console.ReadLine());
                    var zipList = Marschalls.Where(item => item._marschallAdress.ZipCode == zipInput);
                    
                    foreach (var item in zipList)
                    {
                        Console.WriteLine("Resultat: {0}", item._marschallAdress.ZipCode);
                    }
                    SymbolPrint.Line();
                    break;
                case 3:
                    Page.Header("Find Marschalls");
                    Console.WriteLine("Enter Street Name:");
                    string streetInput = Console.ReadLine();
                    var streetList = Marschalls.Where(item => item._marschallAdress.StreetName == streetInput);

                    foreach (var item in streetList)
                    {
                        Console.WriteLine("Resultat: {0}", item._marschallAdress.StreetName);
                    }
                    SymbolPrint.Line();
                    break;
                case 4:
                    Page.Header("Find Marschalls");
                    Console.WriteLine("Enter City:");
                    string cityInput = Console.ReadLine();
                    var cityList = Marschalls.Where(item => item._marschallAdress.City == cityInput);

                    foreach (var item in cityList)
                    {
                        Console.WriteLine("Resultat: {0}", item._marschallAdress.City);
                    }
                    SymbolPrint.Line();
                    break;
                case 5:
                    Page.Header("Find Marschalls");
                    Console.WriteLine("All active: ");
                    foreach (Marschall item in Marschalls)
                    {
                        if (item.IsActive())
                        {
                            item.DisplayMarsachall();
                        }

                    }
                    SymbolPrint.Line();
                    break;
                case 6:
                    Page.Header("Find Marschalls");
                    DisplayAllMarschaller();
                    SymbolPrint.Line();
                    break;
            }

        }
        public static void AddMarschall(User user)
        {
            string brand;
            int burnTime;

            Console.Write("Enter brand: ");
            brand = Console.ReadLine();
            Adress adress = Adress.CreateAdress();    

            while (true)
            {
                Console.Write("Enter Burn Time in hours: ");

                if (int.TryParse(Console.ReadLine(), out burnTime))
                {
                    break;
                }

            }

            new Marschall(user, brand, burnTime, adress);


        }

        public bool IsActive()
        {

           return DateTime.Now < _timeRegistered.AddHours(BurnTime);

        }
        public void DisplayMarsachall()
        {
            Console.WriteLine("ID: {0}", _IdMarschall);
            Console.WriteLine("User: {0}", _user.UserName);
            Console.WriteLine("Brand: {0}", _brand);
            Console.WriteLine("Time Registered: {0}", _timeRegistered);
            Console.WriteLine("BurnTime (hours): {0}", _burnTime);
            Console.WriteLine("Expected burn out time: {0}", _expectedBurnOutTime); 
            _marschallAdress.DisplayAdress();
            Console.WriteLine("Is active: {0}", IsActive() ? "Yes" : "No");
        }
    }
}














