using Microsoft.EntityFrameworkCore;
using Timesheets.Data.Interfaces;
using Timesheets.Models;

namespace Timesheets.Data.Implementation
{
    public class SheetRepo : ISheetRepo
    {
        private readonly TimesheetDbContext _context;

        public SheetRepo(TimesheetDbContext context)
        {
            _context = context;
        }
        public async Task<Sheet> GetItemAsync(Guid id)
        {
            var result = await _context.Sheets.FindAsync(id);

            return result;
        }

        public async Task<IEnumerable<Sheet>> GetItemsAsync()
        {
            var res = await _context.Sheets.AsNoTracking().ToListAsync();
            return res;
        }

        public async Task AddAsync(Sheet sheet)
        {
            await _context.Sheets.AddAsync(sheet);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(Sheet sheet)
        {
            _context.Sheets.Update(sheet);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
