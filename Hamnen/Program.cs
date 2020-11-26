using Hamnen.hamnhantering;
using Hamnen.utilities;
using Hamnen.views;
using System;

namespace Hamnen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup at pgm start: Create new harbourmanager and show UI
            var harbourManager = new HarbourManager();
            HarbourRegisterView.Print(Transform.HarboutMangerToViewModel(harbourManager));

            // Loop one day at a time
            while (true)
            {
                // Prepare harbour for arriving boats
                harbourManager.DecreaseRemainingDaysInHarbour();

                // Generate arriving boats and add them to harbour
                var arrivingBoats = RandomGenerator.BoatGenerator(5);
                harbourManager.AddBoatsToHarbour(arrivingBoats);

                // Update UI
                HarbourRegisterView.Print(Transform.HarboutMangerToViewModel(harbourManager));
            }
        }
    }
}
