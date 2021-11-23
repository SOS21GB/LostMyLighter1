using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighter.Classes
{
    class Marschall
    {
        public static Marschall CurrMarschall;
        public static List<Marschall> Marschalls = new List<Marschall>();


        private string _brand;
        private int _burnTime;
        private DateTime _timeRegistered;
        private Adress _marschallAdress;

        private int _IdMarschall;



        public string Brand { get { return _brand; } }
        public int BurnTime { get { return _burnTime;} }






        public Marschall(string brand, int burnTime, Adress adress)
        {

            this._brand = brand;
            this._burnTime = burnTime;
            this._timeRegistered = DateTime.Now;
            this._marschallAdress = adress;


            _IdMarschall = Marschalls.Count + 1;

            Marschalls.Add(this);

        }


        static void DisplayAllMarschaller()
        {
             string title = "All Marschall";

            foreach (var all in Marschalls)
            {
                Console.WriteLine("ID: {0}", all);

            }
        }


        static void SearchMarschalls()
        {

            while (true)

            {

                Console.WriteLine("Choose how to Search: ");

                Console.WriteLine("1.Brand");
                Console.WriteLine("2.Zip Code");
                Console.WriteLine("3. Street Name ");
                Console.WriteLine("4. City");
                Console.WriteLine("5. See all Active ");
                Console.WriteLine("6. See All");
              
                int choice = Convert.ToInt32(Console.ReadLine());





                switch (choice)
                {

                    case 1:
                        
                        Console.WriteLine("Enter Brand:");

                        string brandInput = Console.ReadLine();

                        var BrandList = Marschalls.Where(item => item._brand == brandInput);

                        foreach (var item in BrandList)
                        {
                            Console.WriteLine("Resultat: {0}", item._brand);
                        }

                        break;
                    
                    case 2:
                        Console.WriteLine("Enter ZipCode:");
                        int zipInput = Convert.ToInt32(Console.ReadLine());

                        var zipList = Marschalls.Where(item => item._marschallAdress.ZipCode == zipInput);

                        foreach (var item in zipList)
                        {
                            Console.WriteLine("Resultat: {0}", item._marschallAdress.ZipCode);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter Street Name:");
                        string streetInput = Console.ReadLine();
                     
                        

                        var streetList = Marschalls.Where(item => item._marschallAdress.StreetName == streetInput);

                        foreach (var item in streetList)
                        {
                            Console.WriteLine("Resultat: {0}", item._marschallAdress.StreetName);
                        }
                        break;

                    case 4:

                        Console.WriteLine("Enter City:");
                        string cityInput = Console.ReadLine();



                        var cityList = Marschalls.Where(item => item._marschallAdress.StreetName == cityInput);

                        foreach (var item in cityList)
                        {
                            Console.WriteLine("Resultat: {0}", item._marschallAdress.City);
                        }
                        break;






                    case 5:
                        Console.WriteLine("All active: ");
                        foreach (Marschall item in Marschalls)
                        {
                            if (item.IsActive())
                            {
                                item.DisplayMarsachall();
                            }

                        }
                        break;


                    case 6:
                        DisplayAllMarschaller();

                        break;

                }


            }

        }
        public static void AddMarschall()
        {

            string brand;
            int burnTime;



            Console.Write("Enter brand: ");
            brand = Console.ReadLine();
            Adress adress = Adress.CreateAdress();    

            while (true)
            {
                Console.Write("Enter Burn Time in minutes: ");
                if (int.TryParse(Console.ReadLine(), out burnTime))
                {
                    break;
                }

            }

            new Marschall(brand, burnTime, adress);



        }

        public bool IsActive()
        {

           return DateTime.Now < _timeRegistered.AddHours(BurnTime);

        }
        public void DisplayMarsachall()
        {
            Console.WriteLine("Brand: {0}", Brand);
            Console.WriteLine("Burn Time: {0}", BurnTime);
            Console.WriteLine("ID: {0}", _IdMarschall );
            Console.WriteLine("Adress:", _marschallAdress);
            Console.WriteLine("Time Registered:", _timeRegistered);
        }
    }






















}














