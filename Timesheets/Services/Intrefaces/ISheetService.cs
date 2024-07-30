using Timesheets.Models;
using Timesheets.Models.Dto.RequestDto;

namespace Timesheets.Services.Intrefaces
{
    public interface ISheetService : IBaseService<SheetRequest, Sheet>
    {
    }
}
