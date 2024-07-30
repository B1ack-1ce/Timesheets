using Microsoft.EntityFrameworkCore;
using Timesheets.Data.Interfaces;
using Timesheets.Models;

namespace Timesheets.Data.Implementation
{
    public class ServiceRepo : IServiceRepo
    {
        private readonly TimesheetDbContext _context;

        public ServiceRepo(TimesheetDbContext context)
        {
            _context = context;
        }

        public async Task<Service> GetItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Service>> GetItemsAsync()
        {
            var result = await _context.Services.AsNoTracking().ToListAsync();
            return result;
        }

        public async Task AddAsync(Service item)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Service item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
