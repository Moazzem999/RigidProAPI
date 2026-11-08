using RigidProAPI.Dtos.Common;

namespace RigidProAPI.Dtos.Employee
{
    public class EmployeeSearchDto : PaginationDto
    {
        public string SearchTerm { get; set; } = string.Empty;
    }
}
