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



        public string Brand;
        public int BurnTime;





        public Marschall(string brand, int burnTime)
        {
            this.Brand = brand;
            this.BurnTime = burnTime;
            this._timeRegistered = DateTime.Now;


            Marschalls.Add(this);

        }


        static void displayAllMarschaller()
        {
            string title = "All Marschall";
            PageManager.PageHeader(title);
            foreach (var all in Marschalls)
            {
                Console.WriteLine("ID: {0}", all);

            }
        }


        static void SearchMarschalls()
        {

            while (true)

            {

                Console.WriteLine("Choose: ");

                Console.WriteLine("1. Enter Brand");
                Console.WriteLine("2. See all Active ");
                int choice = Convert.ToInt32(Console.ReadLine());





                switch (choice)
                {

                    case 1:
                        
                        Console.WriteLine("Enter Brand:");
                        string userInput = Console.ReadLine();

                        var BrandList = Marschalls.Where(item => item._brand == userInput);

                        foreach (var item in BrandList)
                        {
                            Console.WriteLine("Brand: {0}", item._brand);
                        }

                        break;


                    case 2:

                        Console.WriteLine("");   /// ska skriva kod för att kunna se AKtiva MArschaller 
                        

                        break;

                }


            }

        }
        static void AddMarschall()
        {

            string brand;
            int burnTime;
            Adress adress;     // Lägga till "ADd ADress" Metoden o den här klassen 



            Console.Write("Enter brand: ");
            brand = Console.ReadLine();

            while (true)
            {
                Console.Write("Enter Burn Time in minutes: ");
                if (int.TryParse(Console.ReadLine(), out burnTime))
                {
                    break;
                }

            }

        }
    }






















}














