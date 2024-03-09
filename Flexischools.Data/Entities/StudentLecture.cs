namespace Flexischools.Data.Entities
{
    public class StudentLecture
    {
        public Guid LectureId { get; set; }
        public Guid StudentId { get; set; }

        //Navigation Properties
        public virtual Lecture? Lecture { get; set; }
        public virtual Student? Student { get; set; }
    }
}
