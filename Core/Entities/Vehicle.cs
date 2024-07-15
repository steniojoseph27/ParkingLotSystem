using System;

namespace Core.Entities
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public int UserId { get; set; }
        public string LicensePlate { get; set; }
        public string Type { get; set; }
    }
}