using RigidProAPI.Dtos.Common;
using RigidProAPI.Shared.Infrastructure;

namespace RigidProAPI.Repositories.Interfaces
{
    public interface IDropdownRepository
    {
        Task<Result<List<DropdownDto>>> GetAllMaritalStatus();
        Task<Result<List<DropdownDto>>> GetAllReligion();
    }
}
