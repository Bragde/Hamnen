using Hamnen.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hamnen.views
{
    class HarbourRegisterView
    {
        public static void Print(HarbourRegisterViewModel vm)
        {
            Console.Clear();

            // Headers
            Console.WriteLine("Plats\t\tTyp\t\tId\t\tDagar kvar");
            // List of boats
            vm.Boats.ForEach(b => Console.WriteLine($"{b.DockingPlace}\t\t{b.Type}\t{b.Id}\t\t{b.DaysRemaining}"));            
            // Number of rejected boats
            Console.WriteLine($"\nAntal avvisade båtar: {vm.NrRejected}");
            // User input to go to next day
            Console.Write("\nPress any key to go to next day...");
            Console.ReadKey();
        }
    }
}
