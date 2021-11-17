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

            }


        }

    }
}
