using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ParkingSpace
    {
        public int SpaceId { get; set; }
        public string Type { get; set; }
        public bool IsAvailable { get; set; }
    }
}
