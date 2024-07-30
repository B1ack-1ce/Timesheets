using Timesheets.Data.Interfaces;
using Timesheets.Models;
using Timesheets.Models.Dto.RequestDto;
using Timesheets.Services.Intrefaces;

namespace Timesheets.Services.Implementation
{
    public class ContractService : IContractService
    {
        private readonly IContractRepo _contractRepo;
        public ContractService(IContractRepo contractRepo)
        {
            _contractRepo = contractRepo;
        }
        
        public async Task<bool?> CheckContractIsActiveAsync(Guid id)
        {
            return await _contractRepo.CheckContractIsActiveAsync(id);
        }

        public Task<Contract> GetItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Contract>> GetItemsAsync()
        {
            var res = await _contractRepo.GetItemsAsync();
            return res;
        }

        public Task<Guid> CreateAsync(ContractRequest item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, ContractRequest item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
