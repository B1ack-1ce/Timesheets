using Microsoft.AspNetCore.Mvc;
using Timesheets.Services.Intrefaces;

namespace Timesheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _service;
        public ServicesController(IServiceService service)
        {
            _service = service;
        }
        [HttpGet("getServices")]
        public async Task<IActionResult> GetItemsAsync()
        {
            var services = await _service.GetItemsAsync();
            return Ok(services);
        }
    }
}
