using Timesheets.Data.Interfaces;
using Timesheets.Models;

namespace Timesheets.Data.Implementation
{
    public class ClientRepo : IClientRepo
    {
        

        public Task<Client> GetItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Client>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }
        public Task AddAsync(Client item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Client item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
