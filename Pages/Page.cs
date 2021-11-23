using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Classes;

namespace LostMyLighter.Pages
{
    abstract class Page
    {
        protected string _title = "none";

        public virtual void LoadPage(out PageName nextPage)
        {
            nextPage = PageName.None;
        }

        static public void Header(string title)
        {
            Console.Clear();

            Console.WriteLine(SymbolPrint.line);
            Console.WriteLine(title);
            Console.WriteLine(SymbolPrint.line);
        }

        /// <summary>
        /// Call this method to let the user know that the input was not accepted
        /// </summary>
        public static void ErrorMessage(string item, string reason = "is not valid")
        {
            Console.WriteLine();
            Console.WriteLine($"{item} {reason}");
            Console.WriteLine();
            Console.WriteLine(SymbolPrint.line);
            PageManager.PausSleep(2);
        }

    }

    enum PageName 
    { 
        None,
        StartMenu,
        CreateUser,
        EditUser,
        LogIn,
        MainMenu,
        ViewProfile,
        AddRemoveLighter,
        FindMarschalls,
        AddMarschall
    }
}
