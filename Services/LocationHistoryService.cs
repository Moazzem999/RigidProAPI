using RigidProAPI.Dtos.LocationHistory;
using RigidProAPI.Repositories.Interfaces;
using RigidProAPI.Services.Interfaces;
using RigidProAPI.Shared.Infrastructure;

namespace RigidProAPI.Services
{
    public class LocationHistoryService(ILocationHistoryRepository locationHistoryRepository) : ILocationHistoryService
    {
        private readonly ILocationHistoryRepository locationHistoryRepository = locationHistoryRepository;

        public async Task<Result<PagedResult<LocationHistoryResponseDto>>> GetAll(LocationHistorySearchDto searchDto)
        {
            return await locationHistoryRepository.GetAll(searchDto);
        }

        public async Task<Result<LocationHistoryResponseDto>> GetById(long id)
        {
            return await locationHistoryRepository.GetById(id);
        }

        public async Task<Result<long>> Create(LocationHistoryRequestDto dto)
        {
            return await locationHistoryRepository.Create(dto);
        }
    }
}
