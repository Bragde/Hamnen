using System;
using System.Collections.Generic;
using System.Text;

namespace Hamnen.models
{
    interface ISailBoat
    {
        public int Length { get; set; }
    }

    class SailBoat : Boat, ISailBoat
    {
        public SailBoat(string id, int weight, int maxSpeed, int dockSize, int daysRemaining, int length) : base(id, weight, maxSpeed, dockSize, daysRemaining)
        {
            Length = length;
        }

        public int Length { get; set; }
    }
}
