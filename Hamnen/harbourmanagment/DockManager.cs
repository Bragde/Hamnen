using Hamnen.models;
using Hamnen.utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hamnen.hamnhantering
{
    public class DockManager
    {
        public DockManager()
        {
            BoatsInHarbor = new List<Boat>();
            DockSize = 24;
        }

        public List<Boat> BoatsInHarbor { get; set; }
        public int DockSize { get; set; }

        public void DecreaseRemainingDaysInHarbour()
        {
            var boatsInHarbourTemp = BoatsInHarbor;

            foreach(var boat in BoatsInHarbor)
            {
                if (boat.DaysRemaining == 1) BoatsInHarbor.Remove(boat);
                else boat.DaysRemaining--;
            }
        }

        public void AddBoatsToHarbour(List<Boat> arrivingBoats)
        {
            foreach(var arrivingBoat in arrivingBoats)
            {
                var prevBoatEnd = 0;
                var boatDocked = false;
                foreach (var dockedBoat in BoatsInHarbor)
                {                 
                    if (BoatFits(prevBoatEnd, dockedBoat.DockingPlace.Start, arrivingBoat.DockSize))
                    {
                        BoatsInHarbor.Add(SetDockingPlace(prevBoatEnd, arrivingBoat));
                        boatDocked = true;
                        break;
                    }
                    else prevBoatEnd = dockedBoat.DockingPlace.End;
                }
                if (!boatDocked && BoatFits(prevBoatEnd, DockSize, arrivingBoat.DockSize))
                {
                    BoatsInHarbor.Add(SetDockingPlace(prevBoatEnd, arrivingBoat));
                }   
                // Else no room for boat
            }
        }

        private static bool BoatFits(int start, int end, int boatSize)
        {
            return end  - (start + 1) >= boatSize;
        }

        private static Boat SetDockingPlace(int prevBoatEnd, Boat arrivingBoat)
        {
            arrivingBoat.DockingPlace = (
                prevBoatEnd + 1,
                prevBoatEnd + arrivingBoat.DockSize
            );
            return arrivingBoat;
        } 
    }
}
