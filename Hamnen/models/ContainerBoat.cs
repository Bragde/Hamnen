using System;
using System.Collections.Generic;
using System.Text;

namespace Hamnen.models
{
    interface IContainerBoat
    {
        public int Containers { get; set; }
    }

    class ContainerBoat : Boat, IContainerBoat
    {
        public ContainerBoat(string id, int weight, int maxSpeed, int dockSize, int daysRemaining, string type, int containers) : base(id, weight, maxSpeed, dockSize, daysRemaining, type)
        {
            Containers = containers;
        }

        public int Containers { get; set; }
    }
}



