using ParkingLot.Models.Enums;

namespace ParkingLot.Models
{
    public class Vehicle
    {
        public long? VehicleId { get; set; }

        public VehicleType VehicleType { get; set; }

        public string? VehicleName { get; set; }
    }
}
