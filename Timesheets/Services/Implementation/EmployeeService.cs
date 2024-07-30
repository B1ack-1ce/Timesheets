using Timesheets.Data.Interfaces;
using Timesheets.Models;
using Timesheets.Models.Dto.RequestDto;
using Timesheets.Services.Intrefaces;

namespace Timesheets.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeService(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public Task<Employee> GetItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetItemsAsync()
        {
            var employees = await _employeeRepo.GetItemsAsync();
            return employees;
        }

        public Task<Guid> CreateAsync(EmployeeRequest item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, EmployeeRequest item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
