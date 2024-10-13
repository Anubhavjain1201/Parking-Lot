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


    }
}
