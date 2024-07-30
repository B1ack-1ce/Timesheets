using Timesheets.Data.Interfaces;
using Timesheets.Models;
using Timesheets.Models.Dto.RequestDto;
using Timesheets.Services.Intrefaces;

namespace Timesheets.Services.Implementation
{
    public class SheetService : ISheetService
    {
        private readonly ISheetRepo _sheetRepo;

        public SheetService(ISheetRepo sheetRepo)
        {
            _sheetRepo = sheetRepo;
        }

        public async Task<Sheet> GetItemAsync(Guid id)
        {
            var result = await _sheetRepo.GetItemAsync(id);
            return result;

        }

        public async Task<IEnumerable<Sheet>> GetItemsAsync()
        {
            var sheets = await _sheetRepo.GetItemsAsync();
            return sheets;
        }

        public async Task<Guid> CreateAsync(SheetRequest sheetRequest)
        {
            var newSheet = new Sheet
            {
                Id = Guid.NewGuid(),
                Amount = sheetRequest.Amount,
                ContractId = sheetRequest.ContractId,
                Date = sheetRequest.Date,
                EmployeeId = sheetRequest.EmployeeId,
                ServiceId = sheetRequest.ServiceId
            };

            await _sheetRepo.AddAsync(newSheet);

            return newSheet.Id;
        }

        public async Task UpdateAsync(Guid id, SheetRequest sheetRequest)
        {
            var sheet = new Sheet
            {
                Id = id,
                Amount = sheetRequest.Amount,
                ContractId = sheetRequest.ContractId,
                Date = sheetRequest.Date,
                EmployeeId = sheetRequest.EmployeeId,
                ServiceId = sheetRequest.ServiceId
            };

            await _sheetRepo.UpdateAsync(sheet);
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
