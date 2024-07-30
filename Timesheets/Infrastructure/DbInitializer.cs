using Timesheets.Data;
using Timesheets.Models;

namespace Timesheets.Infrastructure
{
    public class DbInitializer
    {
        /// <summary>
        /// Инициализация таблиц начальными данными
        /// </summary>
        /// <param name="context">Контекст базы данных</param>
        internal static void Initialize(TimesheetDbContext context)
        {
             
            if (context.Contracts.Any() && context.Employees.Any() && context.Services.Any())
            {
                return;
            }

            var newContracts = new[]
            {
                new Contract
                {
                    Id = Guid.NewGuid(),
                    Title = "Test 1",
                    DateStart = DateTime.SpecifyKind(DateTime.Parse("20-07-2024"), DateTimeKind.Utc),
                    DateEnd = DateTime.SpecifyKind(DateTime.Parse("25-07-2024"), DateTimeKind.Utc),
                    Description = "Description test 1"
                },
                new Contract
                {
                    Id = Guid.NewGuid(),
                    Title = "Test 2",
                    DateStart = DateTime.SpecifyKind(DateTime.Parse("11-12-2023"), DateTimeKind.Utc),
                    DateEnd = DateTime.SpecifyKind(DateTime.Parse("01-03-2024"), DateTimeKind.Utc),
                    Description = "Description test 2"
                },
                new Contract
                {
                    Id = Guid.NewGuid(),
                    Title = "Test 3",
                    DateStart = DateTime.SpecifyKind(DateTime.Parse("29-12-2024"), DateTimeKind.Utc),
                    DateEnd = DateTime.SpecifyKind(DateTime.Parse("02-02-2026"), DateTimeKind.Utc),
                    Description = "Description test 3"
                },
                new Contract
                {
                    Id = Guid.NewGuid(),
                    Title = "Actuallity contract",
                    DateStart = DateTime.SpecifyKind(DateTime.Parse("10-07-2024"), DateTimeKind.Utc),
                    DateEnd = DateTime.SpecifyKind(DateTime.Parse("02-02-2025"), DateTimeKind.Utc),
                    Description = "Description test 3"
                }
            };

            var newEmployyes = new[]
            {
                new Employee
                {
                    Id= Guid.NewGuid(),
                    UserId = Guid.NewGuid()
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    UserId= Guid.NewGuid()
                }
            };

            var newServices = new[]
            {
                new Service
                {
                    Id = Guid.NewGuid(),
                    Name = "Test 1"
                },
                new Service
                {
                    Id = Guid.NewGuid(),
                    Name = "Test 2"
                }
            };

            context.Contracts.AddRange(newContracts);
            context.Employees.AddRange(newEmployyes);
            context.Services.AddRange(newServices);

            context.SaveChanges();
        }
    }
}
