using System;
using System.Collections.Generic;
using System.Text;

namespace Hamnen.models
{
    interface IMotorBoat
    {
        public int Power { get; set; }
    }

    class MotorBoat : Boat, IMotorBoat
    {
        public MotorBoat(string id, int weight, int maxSpeed, int dockSize, int daysRemaining, string type, int power) : base(id, weight, maxSpeed, dockSize, daysRemaining, type)
        {
            Power = power;
        }

        public int Power { get; set; }
    }
}
