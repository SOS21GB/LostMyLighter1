using System;

namespace LostMyLighter
{
    internal abstract class Page
    {
        protected string _title = "none";

        public virtual void LoadPage(out PageName nextPage)
        {
            nextPage = PageName.None;
        }

        public static void Header(string title)
        {
            Console.Clear();

            SymbolPrint.Line();
            Console.WriteLine(title);
            SymbolPrint.Line();
        }

        /// <summary>
        /// Call this method to let the user know that the input was not accepted
        /// </summary>
        public static void ErrorMessage(string what, string why = "is not valid")
        {
            Console.WriteLine();
            Console.WriteLine($"{what} {why}");
            Console.WriteLine();
            SymbolPrint.Line();

            PageManager.PausSleep(2);
        }
    }

    internal enum PageName
    {
        None,
        StartMenu,
        CreateUser,
        EditUser,
        LogIn,
        MainMenu,
        ViewProfile,
        FindMarschalls,
        AddMarschall,
        FoundLighter,
        EditLightersMenu,
        LostLighter
    }
}