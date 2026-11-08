using RigidProAPI.Dtos.Common;
using RigidProAPI.Repositories.Interfaces;
using RigidProAPI.Shared.Enum;
using RigidProAPI.Shared.Infrastructure;
using RigidProAPI.Shared.Utilities;

namespace RigidProAPI.Repositories
{
    public class DropdownRepository : IDropdownRepository
    {
        public async Task<Result<List<DropdownDto>>> GetAllMaritalStatus()
        {
            var data = Enum.GetValues<MaritalStatus>()
                .Select(x => new DropdownDto
                {
                    Id = (int)x,
                    Name = x.GetEnumDescription()
                })
                .ToList();

            return await Result<List<DropdownDto>>.SuccessAsync("", data);
        }

        public async Task<Result<List<DropdownDto>>> GetAllReligion()
        {
            var data = Enum.GetValues<Religion>()
                .Select(x => new DropdownDto
                {
                    Id = (int)x,
                    Name = x.GetEnumDescription()
                })
                .ToList();

            return await Result<List<DropdownDto>>.SuccessAsync("", data);
        }
    }
}
