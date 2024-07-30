using Microsoft.AspNetCore.Mvc;
using Timesheets.Models;
using Timesheets.Models.Dto.RequestDto;
using Timesheets.Services.Intrefaces;

namespace Timesheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;    
        }

        [HttpGet("getUser")]
        public async Task<IActionResult> GetItemAsync(Guid id)
        {
            var user = await _userService.GetItemAsync(id);
            return Ok(user);
        }

        [HttpGet("getUsers")]
        public async Task<IActionResult> GetItemsAsync()
        {
            var users = await _userService.GetItemsAsync();
            return Ok(users);
        }

        [HttpPost("createUser")]
        public async Task<IActionResult> CreateAsync([FromBody] UserRequest userRequest)
        {
            var guid = await _userService.CreateAsync(userRequest);
            return Ok(guid);
        }

        [HttpPut("updateUser/{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] UserRequest userRequest)
        {
            await _userService.UpdateAsync(id, userRequest);
            return Ok();
        }

        [HttpDelete("deleteUser/{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await _userService.DeleteAsync(id);
            return Ok();
        }
    }
}
