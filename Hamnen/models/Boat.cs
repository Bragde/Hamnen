namespace Hamnen.models
{
    public interface IBoat
    {
        public string Id { get; set; }
        public int Weight { get; set; }
        public int MaxSpeed { get; set; }
        public int DockSize { get; set; }
        public int DaysRemaining { get; set; }
        public (int Start, int End) DockingPlace { get; set; }
    }

    abstract public class Boat: IBoat
    {
        public Boat(string id, int weight, int maxSpeed, int dockSize, int daysRemaining)
        {
            Id = id;
            Weight = weight;
            MaxSpeed = maxSpeed;
            DockSize = dockSize;
            DaysRemaining = daysRemaining;
        }

        public string Id { get; set; }
        public int Weight { get; set; }
        public int MaxSpeed { get; set; }
        public int DockSize { get; set; }
        public int DaysRemaining { get; set; }
        public (int Start, int End) DockingPlace { get; set; }
    }
}
