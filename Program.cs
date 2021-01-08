using System;
using BlackjackCS.Models;
using System.Linq;

namespace BlackjackCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mark", "Paula", "Sandy", "Bill" };

            for (var index = 0; index < names.Length; index++)
            {
                var currentName = names[index];
                Console.WriteLine(currentName);

            }
        }
    }
}
