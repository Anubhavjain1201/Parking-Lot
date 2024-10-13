using System.ComponentModel.DataAnnotations;

namespace ParkingLot.Models.InputDTOs
{
    public class CalculateFareInputDTO
    {
        [Required]
        public long TicketId {  get; set; }

        [Required]
        public DateTime ExitTime { get; set; }
    }
}
