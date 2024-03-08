namespace Flexischools.Data.Entities
{
    public class LectureTheatre
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int Capacity { get; set; }

        //Navigation Properties
        public ICollection<Lecture>? Lectures { get; set; }
    }
}
