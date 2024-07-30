using Microsoft.EntityFrameworkCore;
using Timesheets.Data;
using Timesheets.Data.Implementation;
using Timesheets.Data.Interfaces;
using Timesheets.Services.Implementation;
using Timesheets.Services.Intrefaces;

namespace Timesheets.Infrastructure
{
    internal static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void ConfigurationDbContext(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<TimesheetDbContext>(opt =>
            {
                opt.UseNpgsql(configuration.GetConnectionString("Postgre"));
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigurationDomainServices(this IServiceCollection services)
        {
            services.AddScoped<ISheetService, SheetService>();
            services.AddScoped<IContractService, ContractService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<IUserService, UserService>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigurationRepositories(this IServiceCollection services)
        {
            services.AddScoped<ISheetRepo, SheetRepo>();
            services.AddScoped<IContractRepo, ContractRepo>();
            services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            services.AddScoped<IServiceRepo, ServiceRepo>();
            services.AddScoped<IUserRepo, UserRepo>();
        }
    }
}
