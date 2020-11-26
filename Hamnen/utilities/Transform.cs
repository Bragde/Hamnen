using Hamnen.hamnhantering;
using Hamnen.views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hamnen.utilities
{
    class Transform
    {
        public static HarbourRegisterViewModel HarboutMangerToViewModel(HarbourManager harbourManager)
        {
            var harbourRegister = new List<BoatVeiwModel>();
            var actDockingPlace = 1;

            // Add empty dockingspaces and transform boatsinharbour to boatviewmodels
            harbourManager.BoatsInHarbour.ForEach(b =>
            {
                actDockingPlace = AddEmptyDockingSpaces(actDockingPlace, b.DockingPlace.Start, harbourRegister);                
                     
                harbourRegister.Add(new BoatVeiwModel(
                    b.DockingPlace.Start == b.DockingPlace.End ? $"{b.DockingPlace.Start}" : $"{b.DockingPlace.Start}-{b.DockingPlace.End}",
                    b.Type,
                    b.Id,
                    b.DaysRemaining.ToString()
                ));
                actDockingPlace = b.DockingPlace.End + 1;                
            });

            // Add empty dockingspaces after last boat
            AddEmptyDockingSpaces(actDockingPlace, harbourManager.DockSize + 1, harbourRegister);

            var harbourRegisterViewModel = new HarbourRegisterViewModel(
                harbourRegister,
                harbourManager.NrRejectedBoats
            );

            return harbourRegisterViewModel;
        }

        private static int AddEmptyDockingSpaces(int start, int end, List<BoatVeiwModel> harbourManager)
        {
            var actDockingSpace = start;
            while (actDockingSpace < end)
            {
                harbourManager.Add(new BoatVeiwModel(($"{actDockingSpace}")));
                actDockingSpace++;
            }
            return actDockingSpace;
        }
    }
}
