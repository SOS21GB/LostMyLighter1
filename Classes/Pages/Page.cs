using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostMyLighter.Classes.Pages;

namespace LostMyLighter.Classes.Pages
{
    abstract class Page
    {
        protected string _title = "none";

        public virtual void LoadPage(out string nextPage)
        {
            nextPage = null;
        }

        static public void Header(string title)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(title);
            Console.WriteLine("------------------------------------------------");
        }


    }

    enum PageName { }
}
