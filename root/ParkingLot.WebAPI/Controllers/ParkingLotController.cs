using Microsoft.AspNetCore.Mvc;
using ParkingLot.Models.InputDTOs;

namespace ParkingLot.Controllers
{
    [ApiController]
    [Route("parkingLot")]
    public class ParkingLotController : ControllerBase
    {
        private readonly ILogger<ParkingLotController> _logger;

        public ParkingLotController(ILogger<ParkingLotController> logger)
        {
            _logger = logger;
        }

        [HttpPost("issueTicket")]
        public async Task<IActionResult> IssueTicket([FromBody] IssueTicketInputDTO issueTicketInputDto)
        {
            return Ok(issueTicketInputDto);
        }

        [HttpPost("calculateFare")]
        public async Task<IActionResult> CalculateFare([FromBody] CalculateFareInputDTO calculateFareInputDto)
        {
            return Ok(calculateFareInputDto);
        }

        [HttpPost("exitVehicle")]
        public async Task<IActionResult> ExitVehicle([FromBody] ExitVehicleInputDTO exitVehicleInputDto)
        {
            return Ok(exitVehicleInputDto);
        }

        [HttpPost("makePayment")]
        public async Task<IActionResult> MakePayment([FromBody] PaymentInputDTO paymentInputDto)
        {
            return Ok(paymentInputDto);
        }
    }
}
