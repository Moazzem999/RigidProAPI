using RigidProAPI.Dtos.LocationHistory;
using RigidProAPI.Shared.Infrastructure;

namespace RigidProAPI.Services.Interfaces
{
    public interface ILocationHistoryService
    {
        Task<Result<PagedResult<LocationHistoryResponseDto>>> GetAll(LocationHistorySearchDto searchDto);
        Task<Result<LocationHistoryResponseDto>> GetById(long id);
        Task<Result<long>> Create(LocationHistoryRequestDto dto);
    }
}
