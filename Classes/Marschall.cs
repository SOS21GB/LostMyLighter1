
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
        public int BurnTime { get { return _burnTime; } }

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
            this._expectedBurnOutTime = _timeRegistered.AddHours(BurnTime);
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
            string title = "Find Marschalls";
            int choice = 0;

            while (true)
            {
                Page.Header(title);
                Console.WriteLine("1. Brand");
                Console.WriteLine("2. Zip Code");
                Console.WriteLine("3. Street Name");
                Console.WriteLine("4. City");
                Console.WriteLine("5. See all Active");
                Console.WriteLine("6. See All");
                SymbolPrint.Line();
                Console.Write("Choose how to Search: ");

                if(int.TryParse(Console.ReadLine(), out choice))
                {

                    break;
                }
                Page.Header(title);
                Page.ErrorMessage("Input");
            }
            
            switch (choice)
            {
                case 1:

                    Page.Header(title);
                    Console.Write("Enter Brand: ");
                    string brandInput = Console.ReadLine();
                    var BrandList = Marschalls.Where(item => item._brand == brandInput);
                    int marshallsFound = 0;
                    Page.Header(title);
                    foreach (var item in BrandList)
                    {
                        item.DisplayMarsachall();
                        SymbolPrint.Line();
                        marshallsFound++;
                    }
                    if (marshallsFound < 1)
                    {
                  
                        Page.ErrorMessage("No Marshalls", "could be found");
                        
                    }
             
                    break;
                case 2:
                    int zipInput = 0;
                    while (true)
                    {
                        Page.Header(title);
                        Console.Write("Enter ZipCode: ");
                        if(int.TryParse(Console.ReadLine(), out zipInput))
                        {
                            break;
                        }
                        Page.Header(title);
                        Page.ErrorMessage("Input");
                    }


                    var zipList = Marschalls.Where(item => item._marschallAdress.ZipCode == zipInput);
                    marshallsFound = 0;
                    Page.Header(title);

                    foreach (var item in zipList)
                    {
                        item.DisplayMarsachall();
                        marshallsFound++;
                        SymbolPrint.Line();
                    }
                    if (marshallsFound < 1)
                    {
                       
                        Page.ErrorMessage("No Marshalls", "could be found");
                    }

               
                    break;
                case 3:
                    Page.Header(title);
                    Console.Write("Enter Street Name: ");
                    string streetInput = Console.ReadLine();
                    var streetList = Marschalls.Where(item => item._marschallAdress.StreetName == streetInput);
                    marshallsFound = 0;
                    Page.Header(title);
                    foreach (var item in streetList)
                    {
                        item.DisplayMarsachall();
                        marshallsFound++;
                        SymbolPrint.Line();
                    }
                    if (marshallsFound < 1)
                    {
                       
                        Page.ErrorMessage("No Marshalls", "could be found");
                    }
                    
                    break;
                case 4:
                    Page.Header(title);
                    Console.Write("Enter City: ");
                    string cityInput = Console.ReadLine();
                    var cityList = Marschalls.Where(item => item._marschallAdress.City == cityInput);
                    marshallsFound = 0;
                    Page.Header(title);
                    foreach (var item in cityList)
                    {
                        item.DisplayMarsachall();
                        marshallsFound++;
                        SymbolPrint.Line();
                    }
                    if (marshallsFound < 1)
                    {
                        
                        Page.ErrorMessage("No Marshalls", "could be found");
                    }

                    break;
                case 5:
                    Page.Header(title);
                    Console.WriteLine("All active: \n");
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
                    Page.Header(title);
                    Console.WriteLine("All registered marschalls: \n");
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
                Console.WriteLine("Invalid Input..");
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
            Console.WriteLine();
        }
    }
}














