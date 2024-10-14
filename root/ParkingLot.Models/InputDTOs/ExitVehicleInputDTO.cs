using System.Text.Json.Serialization;

namespace ParkingLot.Models.InputDTOs
{
    public class ExitVehicleInputDTO
    {
        [JsonPropertyName("ticketId")]
        public long TicketId { get; set; }
    }
}
