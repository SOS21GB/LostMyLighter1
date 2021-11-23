using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighter.Classes
{
    static class SymbolPrint
    {

        public static string line = "-------------------------------------------------------------------------------------";


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
            

            string welcomemessage = "Lighters, Marshals and Cigarettes [Version 1.0.0]";
            


            string lightersmarshalsandcigarettes = line+"\n"+
                                                    "Welcome to Lighters, Marshals and Cigarettes\n" +
                                                   line;
                                                 
            string productioncrew = line+"\n"+
                "Production: Max, Johan, Patrick, Elham, Mommo, David";

            string programinfo = "© 2021 Lighter Corporation All rights Reserved";


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
                    Console.WriteLine(programinfo);
                    return;
                case 5:
                    
                    Console.WriteLine(lightersmarshalsandcigarettes);
                    return;
                case 6:
                    Console.WriteLine(productioncrew);
                    return;
                


            }

            /*
             *  
                line + "\n" +
                                                   "┏┓╋╋╋╋╋╋┏┓╋┏┓╋╋╋╋╋╋╋╋╋┏━┓┏━┓╋╋╋╋╋╋╋┏┓╋╋╋╋┏┓╋╋╋╋╋╋╋╋╋╋╋╋┏┓┏━━━┓╋╋╋╋╋╋╋╋╋╋╋┏┓╋┏┓\n" +
                                                   "┃┃╋╋╋╋╋╋┃┃┏┛┗┓╋╋╋╋╋╋╋╋┃┃┗┛┃┃╋╋╋╋╋╋╋┃┃╋╋╋╋┃┃╋╋╋╋╋╋╋╋╋╋╋╋┃┃┃┏━┓┃╋╋╋╋╋╋╋╋╋╋┏┛┗┳┛┗┓\n" +
                                                   "┃┃╋╋┏┳━━┫┗┻┓┏╋━━┳━┳━━┓┃┏┓┏┓┣━━┳━┳━━┫┗━┳━━┫┃┏━━┓┏━━┳━┓┏━┛┃┃┃╋┗╋┳━━┳━━┳━┳━┻┓┏┻┓┏╋━━┳━━┓\n" +
                                                   "┃┃╋┏╋┫┏┓┃┏┓┃┃┃┃━┫┏┫━━┫┃┃┃┃┃┃┏┓┃┏┫━━┫┏┓┃┏┓┃┃┃━━┫┃┏┓┃┏┓┫┏┓┃┃┃╋┏╋┫┏┓┃┏┓┃┏┫┃━┫┃╋┃┃┃┃━┫━━┫\n" +
                                                   "┃┗━┛┃┃┗┛┃┃┃┃┗┫┃━┫┃┣━━┃┃┃┃┃┃┃┏┓┃┃┣━━┃┃┃┃┏┓┃┗╋━━┃┃┏┓┃┃┃┃┗┛┃┃┗━┛┃┃┗┛┃┏┓┃┃┃┃━┫┗┓┃┗┫┃━╋━━┃\n" +
                                                   "┗━━━┻┻━┓┣┛┗┻━┻━━┻┛┗━━┛┗┛┗┛┗┻┛┗┻┛┗━━┻┛┗┻┛┗┻━┻━━┛┗┛┗┻┛┗┻━━┛┗━━━┻┻━┓┣┛┗┻┛┗━━┻━┛┗━┻━━┻━━┛\n" +
                                                   "╋╋╋╋╋┏━┛┃╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋┏━┛┃\n" +
                                                   "╋╋╋╋╋┗━━┛╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋┗━━┛\n" +
                                                   line;
            
            */
        }

    }
}
