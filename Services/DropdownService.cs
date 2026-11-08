using RigidProAPI.Dtos.Common;
using RigidProAPI.Repositories.Interfaces;
using RigidProAPI.Services.Interfaces;
using RigidProAPI.Shared.Infrastructure;

namespace RigidProAPI.Services
{
    public class DropdownService(IDropdownRepository dropdownRepository) : IDropdownService
    {
        private readonly IDropdownRepository dropdownRepository = dropdownRepository;

        public async Task<Result<List<DropdownDto>>> GetAllMaritalStatus()
        {
            return await dropdownRepository.GetAllMaritalStatus();
        }

        public async Task<Result<List<DropdownDto>>> GetAllReligion()
        {
            return await dropdownRepository.GetAllReligion();
        }
    }
}
