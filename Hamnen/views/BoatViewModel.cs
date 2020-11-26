using System;
using System.Collections.Generic;
using System.Text;

namespace Hamnen.views
{
    class BoatVeiwModel
    {
        public BoatVeiwModel(string dockingPlace)
        {
            DockingPlace = dockingPlace;
            Type = "Ledig";
            Id = "";
            DaysRemaining = "";
        }
        public BoatVeiwModel(string dockingPlace, string type, string id, string DaysRemaining)
        {
            DockingPlace = dockingPlace;
            Type = type;
            Id = id;
            this.DaysRemaining = DaysRemaining;
        }


        public string DockingPlace { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public string DaysRemaining { get; set; }
    }
}
