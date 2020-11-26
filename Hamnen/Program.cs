using Hamnen.hamnhantering;
using Hamnen.utilities;
using System;

namespace Hamnen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup at pgm start
            var dockManager = new DockManager();

            //dockManager.PrintDockRegister;

            // Move to next day
            while (true)
            {
                dockManager.DecreaseRemainingDaysInHarbour();

                var arrivingBoats = RandomGenerator.BoatGenerator(5);

                dockManager.AddBoatsToHarbour(arrivingBoats);

                //dockManager.PrintDockRegister;
            }


        }
    }
}
