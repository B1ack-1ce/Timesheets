namespace Timesheets.Models.Dto.RequestDto
{
    public class ContractRequest
    {
        public string Title { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Description { get; set; }

        public ICollection<Sheet> Sheets { get; set; }
    }
}
