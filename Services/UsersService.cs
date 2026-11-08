using RigidProAPI.Dtos.User;
using RigidProAPI.Repositories.Interfaces;
using RigidProAPI.Services.Interfaces;
using RigidProAPI.Shared.Infrastructure;

namespace RigidProAPI.Services
{
    public class UsersService(IUsersRepository usersRepository) : IUsersService
    {
        public async Task<Result<List<UserDto>>> GetAllUsers()
        {
            return await usersRepository.GetAllUsers();
        }

        public async Task<Result<long>> Create(UserRequestDto dto)
        {
            return await usersRepository.Create(dto);
        }

        public async Task<Result<LoginResponseDto>> Login(LoginRequestDto dto)
        {
            return await usersRepository.Login(dto);
        }
    }
}
