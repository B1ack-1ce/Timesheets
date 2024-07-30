using Microsoft.EntityFrameworkCore;
using Timesheets.Data.Interfaces;
using Timesheets.Models;

namespace Timesheets.Data.Implementation
{
    public class ContractRepo : IContractRepo
    {
        private readonly TimesheetDbContext _context;

        public ContractRepo(TimesheetDbContext context)
        {
            _context = context;
        }
        
        public async Task<Contract> GetItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Contract>> GetItemsAsync()
        {
            var result = await _context.Contracts.AsNoTracking().ToListAsync();
            return result;
        }

        public async Task AddAsync(Contract item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Contract item)
        {
            _context.Contracts.Update(item);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool?> CheckContractIsActiveAsync(Guid id)
        {
            var contract = await _context.Contracts.FindAsync(id);
            var now = DateTime.Now;
            var isActive = now <= contract?.DateEnd && now >= contract?.DateStart;

            return isActive;
        }
    }
}
