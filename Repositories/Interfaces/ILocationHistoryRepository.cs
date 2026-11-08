using RigidProAPI.Dtos.LocationHistory;
using RigidProAPI.Shared.Infrastructure;

namespace RigidProAPI.Repositories.Interfaces
{
    public interface ILocationHistoryRepository
    {
        Task<Result<PagedResult<LocationHistoryResponseDto>>> GetAll(LocationHistorySearchDto searchDto);
        Task<Result<LocationHistoryResponseDto>> GetById(long id);
        Task<Result<long>> Create(LocationHistoryRequestDto dto);
    }
}
