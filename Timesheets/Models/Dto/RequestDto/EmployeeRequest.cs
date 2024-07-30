namespace Timesheets.Models.Dto.RequestDto
{
    public class EmployeeRequest
    {
        public Guid UserId { get; set; }
        public ICollection<Sheet> Sheets { get; set; }
    }
}
