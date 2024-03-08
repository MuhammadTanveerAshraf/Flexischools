namespace Flexischools.Data.Entities
{
    public class Lecture
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public Guid LectureTheatreId { get; set; }
        public Guid SubjectId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public required string WeekDay { get; set; }

        //Navigation Properties
        public LectureTheatre? LectureTheatre { get; set; }
        public virtual ICollection<Student>? Students { get; set; }
    }
}
