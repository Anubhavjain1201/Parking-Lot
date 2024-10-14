using ParkingLot.Models.Enums;
using System.Text.Json.Serialization;

namespace ParkingLot.Models.InputDTOs
{
    public class PaymentInputDTO
    {
        [JsonPropertyName("ticketId")]
        public long TicketId { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("paymentMode")]
        public PaymentMode PaymentMode { get; set; }
    }
}
