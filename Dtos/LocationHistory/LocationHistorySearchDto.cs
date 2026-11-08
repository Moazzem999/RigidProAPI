using RigidProAPI.Dtos.Common;

namespace RigidProAPI.Dtos.LocationHistory
{
    public class LocationHistorySearchDto : PaginationDto
    {
        public long? EmployeeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
