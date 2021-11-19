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

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(title);
            Console.WriteLine("------------------------------------------------");
        }

        /// <summary>
        /// Call this method to let the user know that the input was not accepted
        /// </summary>
        protected static void ErrorMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Input not valid");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            PageManager.PausSleep(2);
        }

    }

    enum PageName 
    { 
        None,
        StartMenu,
        CreateUser,
        LogIn,
        MainMenu,
        ViewProfile,
        AddRemoveLighter,
        FindMarschalls,
        AddMarschall
    }
}
