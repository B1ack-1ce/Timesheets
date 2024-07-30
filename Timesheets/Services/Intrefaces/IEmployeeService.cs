using Timesheets.Models;
using Timesheets.Models.Dto.RequestDto;

namespace Timesheets.Services.Intrefaces
{
    public interface IEmployeeService : IBaseService<EmployeeRequest, Employee>
    {
    }
}
