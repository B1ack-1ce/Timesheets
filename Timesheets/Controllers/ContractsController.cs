using Microsoft.AspNetCore.Mvc;
using Timesheets.Services.Intrefaces;

namespace Timesheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        private readonly IContractService _contractService;
        public ContractsController(IContractService contractService)
        {
            _contractService = contractService;
        }

        [HttpGet("getContracts")]
        public async Task<IActionResult> GetItemsAsync()
        {
            var contracts = await _contractService.GetItemsAsync();
            return Ok(contracts);
        }
        
    }
}
