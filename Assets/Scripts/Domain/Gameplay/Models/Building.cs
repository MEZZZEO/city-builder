using System;

namespace Domain.Gameplay.Models
{
    public class Building
    {
        public Guid Id { get; }
        public BuildingType Type { get; }
        public GridPosition Position { get; private set; }
        public int Level { get; private set; }
        public int Rotation { get; private set; }

        public Building()
        {
            Id = Guid.NewGuid();
        }
    }
}