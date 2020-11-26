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
        public SailBoat(string id, int weight, int maxSpeed, int dockSize, int daysRemaining, string type, int length) : base(id, weight, maxSpeed, dockSize, daysRemaining, type)
        {
            Length = length;
        }

        public int Length { get; set; }
    }
}
