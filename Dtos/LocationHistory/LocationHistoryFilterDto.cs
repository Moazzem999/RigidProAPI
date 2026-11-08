using RigidProAPI.Dtos.Common;

namespace RigidProAPI.Dtos.LocationHistory
{
    public class LocationHistoryFilterDto : PaginationDto
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
