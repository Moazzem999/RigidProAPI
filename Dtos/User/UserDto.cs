using RigidProAPI.Dtos.Common;
using System.Text.Json.Serialization;

namespace RigidProAPI.Dtos.User
{
    public class UserDto : BaseDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? UserName { get; set; }

        [JsonIgnore]
        public string? Password { get; set; }
    }
}
