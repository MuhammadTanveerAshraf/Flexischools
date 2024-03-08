namespace Flexischools.Data.Entities
{
    public class Subject
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        //Navigation Properties
        public virtual ICollection<Student>? Students { get; set; }
    }
}
