namespace Timesheets.Models.Dto.RequestDto
{
    public class ServiceRequest
    {
        public string Name { get; set; }
        public ICollection<Sheet> Sheets { get; set; }
    }
}
