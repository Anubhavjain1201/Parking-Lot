using System.Text.Json.Serialization;

namespace ParkingLot.Models.OutputDTOs
{
    public class IssueTicketOutputDTO
    {
        [JsonPropertyName("ticketId")]
        public long TicketId { get; set; }

        [JsonPropertyName("entryTime")]
        public DateTime EntryTime { get; set; }

        [JsonPropertyName("vehicleNumber")]
        public string? VehicleNumber { get; set; }

        [JsonPropertyName("slotId")]
        public long SlotId { get; set; }

    }
}
