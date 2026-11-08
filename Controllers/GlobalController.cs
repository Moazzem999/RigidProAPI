using Microsoft.AspNetCore.Mvc;
using RigidProAPI.Dtos.LocationHistory;
using RigidProAPI.Services.Interfaces;

namespace RigidProAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GlobalController(ILocationHistoryService locationHistoryService) : ControllerBase
    {

        [HttpPost("AddLocation")]
        public async Task<IActionResult> AddLocation([FromBody] LocationHistoryRequestDto dto)
        {
            var result = await locationHistoryService.Create(dto);
            return Ok(result);
        }
    }
}
