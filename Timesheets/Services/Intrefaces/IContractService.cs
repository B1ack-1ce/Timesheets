using Timesheets.Models;
using Timesheets.Models.Dto.RequestDto;

namespace Timesheets.Services.Intrefaces
{
    /// <summary>
    /// Временное решение, чтобы получать контракты
    /// </summary>
    public interface IContractService : IBaseService<ContractRequest, Contract>
    {
        public Task<bool?> CheckContractIsActiveAsync(Guid id);
    }
}
