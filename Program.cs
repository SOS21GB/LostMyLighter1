using System;
using LostMyLighter.Classes;


namespace LostMyLighter
{
    class Program
    {
        static void Main(string[] args)
        {
            Testing.PremadeUsers();
            Testing.PremadeActiveMarchallers();
            Testing.PremadeInactiveMarchallers();

            PageManager.RunApp();
        }

    }
}

