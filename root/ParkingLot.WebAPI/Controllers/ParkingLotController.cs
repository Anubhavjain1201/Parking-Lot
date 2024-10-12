using Microsoft.AspNetCore.Mvc;

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
    }
}
