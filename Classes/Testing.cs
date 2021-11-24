using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighter.Classes
{
   static class Testing
    {
        public static void PremadeUsers()
        {
           new User("Funky", 77, new Adress("Stockholmsvägen", "9B", "Skara", 53289), "1");
           new User("Freedom", 13, new Adress("Fredsgatan17", "2A", "Stockholm", 12398), "2");
        }

        public static void PremadeActiveMarchallers()
        {
            new Marschall("Marchall XXL", 6, new Adress("Sveavägen", "1A", "Skara", 59875));
            new Marschall("Marchall Svea", 4, new Adress("Sveavägen", "1A", "Skara", 59875));            
        }

        public static void PremadeInactiveMarchallers()
        {
            new Marschall("Marchall Svea", 6, 72, new Adress("Vasagatan", "7A", "Stockholm", 12453));
        }
    }   
}
