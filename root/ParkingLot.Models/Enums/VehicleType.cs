using System.Runtime.Serialization;

namespace ParkingLot.Models.Enums
{
    public enum VehicleType
    {
        [EnumMember(Value = "Car")]
        CAR,

        [EnumMember(Value = "Auto")]
        AUTO,

        [EnumMember(Value = "Bike")]
        BIKE,

        [EnumMember(Value = "Scooter")]
        SCOOTER
    }
}
