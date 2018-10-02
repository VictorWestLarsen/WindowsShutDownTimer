using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmartMenuLibrary
{
    class Bindings
    {
        public static void Call(String menuId)
        {
            // Implement call here 
            // Hint - lav switch case some caller metoderne i functions.cs og printer resultatet. 
            if (menuId == "1")
            {
                Console.WriteLine("Du har valgt nummer 1 her skal du indtaste hvor lang tid der er til din pc skal slukke");
            }
            else if (menuId == "2")
            {
                Console.WriteLine("Nummer 2 skulle gerne annullere din nedlukning");

            }
            else if (menuId == "3")
            {
                Console.WriteLine("Denne her skulle gerne lukke programmet");
            }
        }
    }
}
