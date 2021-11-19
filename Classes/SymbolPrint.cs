using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighter.Classes
{
    static class SymbolPrint
    {
        public static void Symbols(int symbol)
        {
            string marchall = "*****\n" +
                              "*   *\n" +
                              "* * *\n" +
                              "*   *\n" +
                              "*****";
            string lighter = "  _    \n" +
                             " | |  \n" +
                             " | |  \n" +
                             " | |  \n" +
                             " | |  \n" +
                             " | |    )\n" +
                             " | |   .(\n" +
                             " ) | _(, ')\n" +
                             " | o______ |\n" +
                             " |         |\n" +
                             " | ||      |\n" +
                             " | ||      |\n" +
                             " | ||      |\n" +
                             " | || jgs  |\n" +
                             " '---------'";

            string brokenlighter = "  _    \n" +
                                   " | |  \n" +
                                   " | |  \n" +
                                   " | |  \n" +
                                   " | |  \n" +
                                   " | |    )\n" +
                                   " | |   .(\n" +
                                   " )* | _(, ')\n" +
                                   " |**o______ |\n" +
                                   " |**        |\n" +
                                   " |***       |\n" +
                                   " |****      |\n" +
                                   " |*****     |\n" +
                                   " |******s   |\n" +
                                   " '********--'";
            
            string welcomemessage = "Welcome to Lighters, Marshals and Cigarettes produced by Lighter Corporation";

            string lightersmarshalsandcigarettes = "┏┓╋╋╋╋╋╋┏┓╋┏┓╋╋╋╋╋╋╋╋╋┏━┓┏━┓╋╋╋╋╋╋╋┏┓╋╋╋╋┏┓╋╋╋╋╋╋╋╋╋╋╋╋┏┓┏━━━┓╋╋╋╋╋╋╋╋╋╋╋┏┓╋┏┓\n" +
                                                   "┃┃╋╋╋╋╋╋┃┃┏┛┗┓╋╋╋╋╋╋╋╋┃┃┗┛┃┃╋╋╋╋╋╋╋┃┃╋╋╋╋┃┃╋╋╋╋╋╋╋╋╋╋╋╋┃┃┃┏━┓┃╋╋╋╋╋╋╋╋╋╋┏┛┗┳┛┗┓\n" +
                                                   "┃┃╋╋┏┳━━┫┗┻┓┏╋━━┳━┳━━┓┃┏┓┏┓┣━━┳━┳━━┫┗━┳━━┫┃┏━━┓┏━━┳━┓┏━┛┃┃┃╋┗╋┳━━┳━━┳━┳━┻┓┏┻┓┏╋━━┳━━┓\n" +
                                                   "┃┃╋┏╋┫┏┓┃┏┓┃┃┃┃━┫┏┫━━┫┃┃┃┃┃┃┏┓┃┏┫━━┫┏┓┃┏┓┃┃┃━━┫┃┏┓┃┏┓┫┏┓┃┃┃╋┏╋┫┏┓┃┏┓┃┏┫┃━┫┃╋┃┃┃┃━┫━━┫\n" +
                                                   "┃┗━┛┃┃┗┛┃┃┃┃┗┫┃━┫┃┣━━┃┃┃┃┃┃┃┏┓┃┃┣━━┃┃┃┃┏┓┃┗╋━━┃┃┏┓┃┃┃┃┗┛┃┃┗━┛┃┃┗┛┃┏┓┃┃┃┃━┫┗┓┃┗┫┃━╋━━┃\n" +
                                                   "┗━━━┻┻━┓┣┛┗┻━┻━━┻┛┗━━┛┗┛┗┛┗┻┛┗┻┛┗━━┻┛┗┻┛┗┻━┻━━┛┗┛┗┻┛┗┻━━┛┗━━━┻┻━┓┣┛┗┻┛┗━━┻━┛┗━┻━━┻━━┛\n" +
                                                   "╋╋╋╋╋┏━┛┃╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋┏━┛┃\n" +
                                                   "╋╋╋╋╋┗━━┛╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋┗━━┛";

            string versionnumber = "Version 1.0.0";

            string productioncrew = "Production: Max, Johan, Patrick, Elham, Mommo, David ";

            string productionyear = "© 2021 Lighter Corporation";

            string allrightsreserved = "All Rights Reserved";

            switch (symbol)
            {
                case 1:
                    Console.WriteLine(marchall);
                    return;
                case 2:
                    Console.WriteLine(lighter);
                    return;
                case 3:
                    Console.WriteLine(brokenlighter);
                    return;
                case 4:
                    Console.WriteLine(welcomemessage);
                    return;
                case 5:
                    Console.WriteLine(lightersmarshalsandcigarettes);
                    return;
                case 6:
                    Console.WriteLine(versionnumber);
                    return;
                case 7:
                    Console.WriteLine(productioncrew);
                    return;
                case 8:
                    Console.WriteLine(productionyear);
                    return;
                case 9:
                    Console.WriteLine(allrightsreserved);
                    return;


            }


        }

    }
}
