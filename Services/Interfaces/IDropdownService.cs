using RigidProAPI.Dtos.Common;
using RigidProAPI.Shared.Infrastructure;

namespace RigidProAPI.Services.Interfaces
{
    public interface IDropdownService
    {
        Task<Result<List<DropdownDto>>> GetAllMaritalStatus();
        Task<Result<List<DropdownDto>>> GetAllReligion();
    }
}
