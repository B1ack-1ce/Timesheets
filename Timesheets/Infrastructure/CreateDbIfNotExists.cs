using Timesheets.Data;

namespace Timesheets.Infrastructure
{
    public static class CreateDbIfNotExists
    {
        /// <summary>
        /// Добавление начальных данных, если БД пустая
        /// </summary>
        /// <param name="host"></param>
        public static void AddTestingData(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<TimesheetDbContext>();

                DbInitializer.Initialize(context);
            }
        }
    }
}
