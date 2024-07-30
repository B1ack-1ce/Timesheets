using Microsoft.EntityFrameworkCore;
using Timesheets.Models;

namespace Timesheets.Data
{
    public class TimesheetDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Sheet> Sheets { get; set; }
        public DbSet<User> Users { get; set; }

        public TimesheetDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("clients");

            modelBuilder.Entity<Contract>(contract =>
            {
                //contract.Property(p => p.DateStart).HasColumnType("timestamp without time zone");
                //contract.Property(p => p.DateEnd).HasColumnType("timestamp without time zone");
                contract.ToTable("contracts");
            });

            modelBuilder.Entity<Employee>().ToTable("employees");

            modelBuilder.Entity<Service>().ToTable("services");

            modelBuilder.Entity<Sheet>(sheet =>
            {
                //sheet.Property(p => p.Date).HasColumnType("timestamp without time zone");
                sheet.ToTable("sheets");
            });

            modelBuilder.Entity<User>().ToTable("users");


            modelBuilder.Entity<Sheet>()
                .HasOne(sheet => sheet.Contract)
                .WithMany(contract => contract.Sheets)
                .HasForeignKey(sheet => sheet.ContractId);

            modelBuilder.Entity<Sheet>()
                .HasOne(sheet => sheet.Service)
                .WithMany(service => service.Sheets)
                .HasForeignKey(sheet => sheet.ServiceId);

            modelBuilder.Entity<Sheet>()
                .HasOne(sheet => sheet.Employee)
                .WithMany(employee => employee.Sheets)
                .HasForeignKey(sheet => sheet.EmployeeId);
        }
    }
}
