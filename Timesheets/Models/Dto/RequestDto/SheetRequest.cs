namespace Timesheets.Models.Dto.RequestDto
{
    /// <summary>
    /// Входящий Sheet
    /// </summary>
    public class SheetRequest
    {
        /// <summary>
        /// Дата и время 
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Guid сотрудника
        /// </summary>
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Guid договора с клиентом
        /// </summary>
        public Guid ContractId { get; set; }

        /// <summary>
        /// Guid предоставляемой услуги
        /// </summary>
        public Guid ServiceId { get; set; }

        /// <summary>
        /// Время выполенения (в часах)
        /// </summary>
        public int Amount { get; set; }
    }
}
