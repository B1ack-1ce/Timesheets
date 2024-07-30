using Timesheets.Data.Interfaces;
using Timesheets.Models;
using Timesheets.Models.Dto.RequestDto;
using Timesheets.Services.Intrefaces;

namespace Timesheets.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public Task<User> GetItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Guid> CreateAsync(UserRequest item)
        {
            throw new NotImplementedException();
        }
        public Task UpdateAsync(Guid id, UserRequest item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
