using System;

namespace Core.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public int SpaceId { get; set; }
        public int VehicleId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}