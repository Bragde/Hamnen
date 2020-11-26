using Hamnen.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hamnen.utilities
{
    public class RandomGenerator
    { 
        private readonly Random _random = new Random();
    
        private int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
  
        private string RandomString(int size)
        {
            var builder = new StringBuilder(size);
            const char offset = 'A';
            const int lettersOffset = 26;

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return builder.ToString();
        }

        public static List<Boat> BoatGenerator(int nrBoats)
        {
            var boats = new List<Boat>();
            var generator = new RandomGenerator();

            // Generate a number of random boat types with coresponding data
            for(var i = 0; i < nrBoats; i++)
            {
                string id, type;
                int weight, maxSpeed, dockSize, daysRemaining;

                var boatType = generator.RandomNumber(1, 4);
                if (boatType == 1) // Motorboat
                {
                    id = $"M-{generator.RandomString(3)}";
                    weight = generator.RandomNumber(200, 301);
                    maxSpeed = generator.RandomNumber(0, 61);
                    dockSize = 1;
                    daysRemaining = 3;
                    type = "Motorbåt";
                    var power = generator.RandomNumber(10, 1001);
                    boats.Add(new MotorBoat(id, weight, maxSpeed, dockSize, daysRemaining, type, power));
                }
                else if (boatType == 2) // Sailboat
                {
                    id = $"S-{generator.RandomString(3)}";
                    weight = generator.RandomNumber(800, 6001);
                    maxSpeed = generator.RandomNumber(0, 13);
                    dockSize = 2;
                    daysRemaining = 4;
                    type = "Segelbåt";
                    var length = generator.RandomNumber(10, 61);
                    boats.Add(new SailBoat(id, weight, maxSpeed, dockSize, daysRemaining, type, length));
                }
                else if (boatType == 3) // Containerboat
                {
                    id = $"L-{generator.RandomString(3)}";
                    weight = generator.RandomNumber(3000, 20001);
                    maxSpeed = generator.RandomNumber(0, 21);
                    dockSize = 4;
                    daysRemaining = 6;
                    type = "Lastfartyg";
                    var containers = generator.RandomNumber(0, 501);
                    boats.Add(new ContainerBoat(id, weight, maxSpeed, dockSize, daysRemaining, type, containers));
                }
            }

            return boats;
        }
    }
}
