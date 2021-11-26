using System;

namespace LostMyLighter
{
    internal static class SymbolPrint
    {
        public static void Line()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }

        public static void Symbols(int symbol)
        {
            string marchall = @"

    )
   ) \
  / ) (
  \(*)/
*********
*********
*********";
            string lighter = @"
 _
| |
| |
| |
| |
| |    )
| |   .(
) | _(, ')
| o______ |
|         |
| ||      |
| ||      |
| ||      |
| || jgs  |
'---------'";

            string brokenlighter = @"
 _
| |
| |
| |
| |
| |    )
| |   .(
) | _(, ')
|**o______ |
|**        |
|***       |
|****      |
|*****     |
|******s   |
'********--'";

            string welcomemessage = "Lighters, Marshalls and Cigarettes [Version 1.0.0]";

            string lightersmarshalsandcigarettes = "\n" +
                                                    "Welcome to Lighters, Marshalls and Cigarettes\n";
            string logoutMessage = "\n" +
                                                  "Good Bye & Please do Come Again!\n";

            string productioncrew = "Production: Max, Johan, Patrick, Elham, Mommo, David";

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
                    Line();
                    Console.WriteLine(lightersmarshalsandcigarettes);
                    Line();
                    return;

                case 6:
                    Line();
                    Console.WriteLine(productioncrew);
                    return;

                case 7:
                    Line();
                    Console.WriteLine(logoutMessage);
                    Line();
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