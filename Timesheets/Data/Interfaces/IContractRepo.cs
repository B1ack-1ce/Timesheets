using Timesheets.Models;

namespace Timesheets.Data.Interfaces
{
    public interface IContractRepo : IRepoBase<Contract>
    {
        Task<bool?> CheckContractIsActiveAsync(Guid id);
    }
}
