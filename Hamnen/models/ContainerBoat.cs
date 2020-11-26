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
        public ContainerBoat(string id, int weight, int maxSpeed, int dockSize, int daysRemaining, int containers) : base(id, weight, maxSpeed, dockSize, daysRemaining)
        {
            Containers = containers;
        }

        public int Containers { get; set; }
    }
}



