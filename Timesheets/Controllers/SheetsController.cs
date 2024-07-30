using Microsoft.AspNetCore.Mvc;
using Timesheets.Models;
using Timesheets.Models.Dto.RequestDto;
using Timesheets.Services.Intrefaces;

namespace Timesheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SheetsController : ControllerBase
    {
        private readonly ISheetService _sheetService;
        private readonly IContractService _contractService;

        public SheetsController(ISheetService sheetService, IContractService contractService)
        {
            _sheetService = sheetService;
            _contractService = contractService;
        }

        [HttpGet("getSheet/{id}")]
        public async Task<IActionResult> GetItemAsync([FromQuery]Guid id)
        {
            return Ok(await _sheetService.GetItemAsync(id));
        }

        [HttpGet("getSheets")]
        public async Task<IActionResult> GetItemsAsync()
        {
            var sheets = await _sheetService.GetItemsAsync();
            return Ok(sheets);
        }

        [HttpPost("createSheet")]
        public async Task<IActionResult> CreateAsync([FromBody] SheetRequest sheet)
        {
            var isAllowedToCreate = await _contractService.CheckContractIsActiveAsync(sheet.ContractId);

            if (isAllowedToCreate is not null && !isAllowedToCreate.Value)
            {
                return BadRequest($"Contract {sheet.ContractId} is not active or not found");
            }

            var res = await _sheetService.CreateAsync(sheet);
            return Ok(res);
        }
        /// <summary>
        /// Обновить существующую запись Sheet 
        /// </summary>
        /// <param name="id">Guid записи</param>
        /// <param name="sheetRequest">Данные для обновления</param>
        /// <returns></returns>
        [HttpPut("updateSheet")]
        public async Task<IActionResult> UpdateAsync([FromQuery] Guid id, [FromBody] SheetRequest sheetRequest)
        {
            var isAllowedToCreate = await _contractService.CheckContractIsActiveAsync(sheetRequest.ContractId);

            if (isAllowedToCreate is not null && !isAllowedToCreate.Value)
            {
                return BadRequest($"Contract {sheetRequest.ContractId} is not active or not found");
            }

            await _sheetService.UpdateAsync(id, sheetRequest);

            return Ok();
        }
    }
}
