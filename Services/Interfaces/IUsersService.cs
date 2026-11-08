using RigidProAPI.Dtos.User;
using RigidProAPI.Shared.Infrastructure;

namespace RigidProAPI.Services.Interfaces
{
    public interface IUsersService
    {
        Task<Result<List<UserDto>>> GetAllUsers();
        Task<Result<long>> Create(UserRequestDto dto);
        Task<Result<LoginResponseDto>> Login(LoginRequestDto dto);
    }
}
