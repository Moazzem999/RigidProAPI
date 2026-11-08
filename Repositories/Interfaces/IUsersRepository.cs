using RigidProAPI.Dtos.User;
using RigidProAPI.Shared.Infrastructure;

namespace RigidProAPI.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        Task<Result<List<UserDto>>> GetAllUsers();
        Task<Result<long>> Create(UserRequestDto dto);
        Task<Result<LoginResponseDto>> Login(LoginRequestDto dto);
    }
}
