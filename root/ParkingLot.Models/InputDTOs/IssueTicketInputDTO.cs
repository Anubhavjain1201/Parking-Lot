using ParkingLot.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ParkingLot.Models.InputDTOs
{
    public class IssueTicketInputDTO
    {
        [JsonPropertyName("parkingLotId")]
        [Required]
        public long ParkingLotId { get; set; }

        [JsonPropertyName("vehicleType")]
        [Required]
        public VehicleType VehicleType { get; set; }

        [JsonPropertyName("vehicleNumber")]
        [Required]
        public string VehicleNumber { get; set; } = string.Empty;

    }
}
