using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LostMyLighter.Classes
{
    class WriteAllLines
    {
        public static async Task ExampleAsync()
        {
            string[] lines =
            {
                "First", "Second", "Third"
            };
            await File.WriteAllLinesAsync("Users.txt", lines);
        }
    }
}
