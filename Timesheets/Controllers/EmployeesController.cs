using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Timesheets.Models;
using Timesheets.Services.Intrefaces;

namespace Timesheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("getEmployees")]
        public async Task<IActionResult> GetItemsAsync()
        {
            var employees = await _employeeService.GetItemsAsync();
            return Ok(employees);
        }
        
        //ToDo CRUD methods
    }
}
