using static Flexischools.Data.Enum.Enums;

namespace Flexischools.Data.Models.Request
{
    public class AddLectureRequest
    {
        public required string Title { get; set; }
        public Guid SubjectId { get; set; }
        public Guid LectureTheatreId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public WeekDays WeekDay { get; set; }
    }
}
