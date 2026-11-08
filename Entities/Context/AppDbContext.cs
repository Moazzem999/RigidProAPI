using RigidProAPI.Shared.Services;
using Microsoft.EntityFrameworkCore;

namespace RigidProAPI.Entities.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options,
    ICurrentUserService currentUserService) : BaseDbContext(options, currentUserService)
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<LocationHistoryEntity> LocationHistories { get; set; }
    }
}
