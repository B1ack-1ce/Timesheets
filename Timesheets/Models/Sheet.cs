namespace Timesheets.Models
{
    /// <summary>
    /// Информация о затраченном времени  сотрудника
    /// </summary>
    public class Sheet
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid ContractId { get; set; }
        public Guid ServiceId { get; set; }
        public int Amount { get; set; }
        public bool IsDeleted { get; set; } = false;

        public Employee Employee { get; set; }
        public Contract Contract { get; set; }
        public Service Service { get; set; }
    }
}
