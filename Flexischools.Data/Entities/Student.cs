namespace Flexischools.Data.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        //Navigation Properties
        public virtual ICollection<Subject>? Subjects { get; set; }
        public virtual ICollection<Lecture>? Lectures { get; set; }
    }
}
