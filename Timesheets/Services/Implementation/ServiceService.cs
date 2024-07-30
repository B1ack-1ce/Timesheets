using Timesheets.Data.Interfaces;
using Timesheets.Models;
using Timesheets.Models.Dto.RequestDto;
using Timesheets.Services.Intrefaces;

namespace Timesheets.Services.Implementation
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepo _serviceRepo;

        public ServiceService(IServiceRepo serviceRepo)
        {
            _serviceRepo = serviceRepo;
        }
        public Task<Service> GetItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Service>> GetItemsAsync()
        {
            var services = await _serviceRepo.GetItemsAsync();
            return services;
        }

        public Task<Guid> CreateAsync(ServiceRequest item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, ServiceRequest item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
