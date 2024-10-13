namespace ParkingLot.Models
{
    public class Ticket
    {
        public long? TicketId { get; set; }

        public Vehicle? Vehicle { get; set; }

        public DateTime EntryTime { get; set; }

        public DateTime ExitTime { get; set; }

        //public Spot Spot { get; set; }
    }
}
