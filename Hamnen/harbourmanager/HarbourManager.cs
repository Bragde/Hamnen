using Hamnen.models;
using Hamnen.utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hamnen.hamnhantering
{
    public class HarbourManager
    {
        public HarbourManager()
        {
            BoatsInHarbour = new List<Boat>();
            DockSize = 25;
            NrRejectedBoats = 0;
        }

        public List<Boat> BoatsInHarbour { get; set; }
        public int DockSize { get; set; }
        public int NrRejectedBoats { get; set; }

        public void DecreaseRemainingDaysInHarbour()
        {
            BoatsInHarbour.RemoveAll(b => b.DaysRemaining == 1);
            BoatsInHarbour.ForEach(b => b.DaysRemaining--);
        }

        public void AddBoatsToHarbour(List<Boat> arrivingBoats)
        {           
            foreach(var arrivingBoat in arrivingBoats)
            {
                var prevBoatEnd = 0;
                var boatDocked = false;
                // Check if arriving boat fits between existing boats
                foreach (var dockedBoat in BoatsInHarbour)
                {                 
                    if (CheckBoatFits(prevBoatEnd, dockedBoat.DockingPlace.Start, arrivingBoat.DockSize))
                    {
                        BoatsInHarbour.Add(SetDockingPlace(prevBoatEnd, arrivingBoat));
                        BoatsInHarbour = BoatsInHarbour.OrderBy(b => b.DockingPlace.Start).ToList();
                        boatDocked = true;
                        break;
                    }
                    else prevBoatEnd = dockedBoat.DockingPlace.End;
                }
                // Check if arriving boat fits after existing boats
                if (!boatDocked)
                {
                    if(CheckBoatFits(prevBoatEnd, (DockSize + 1), arrivingBoat.DockSize))
                        BoatsInHarbour.Add(SetDockingPlace(prevBoatEnd, arrivingBoat));
                    else 
                        NrRejectedBoats++;
                }
            }
        }

        private static bool CheckBoatFits(int start, int end, int boatSize)
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
