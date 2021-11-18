using System;
using System.IO;
using System.Threading.Tasks;
using LostMyLighter.Classes;


namespace LostMyLighter
{
    class Program
    {
        static void Main(string[] args)
        {
            Testing.PremadeUsers();
            //WriteAllLines.ExampleAsync();
            //ExampleAsync();
            Append();
            PageManager.RunApp();

        }

        public static async Task ExampleAsync()
        {
            
            await File.WriteAllLinesAsync("Users.txt", User.Users[1].GetValues());

        }
         public static async Task Append()
        {
            using StreamWriter file = new("Users.txt", append: true);
            

            foreach (var item in User.Users[1].GetValues())
            {
                await file.WriteLineAsync(item);
            }
        }
    }
            
}

