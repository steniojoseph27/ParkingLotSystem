using System;

namespace Core.Entities
{
    public class ParkingSpace
    {
        public int SpaceId { get; set; }
        public string Type { get; set; }
        public bool IsAvailable { get; set; }
    }
}

