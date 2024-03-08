using Microsoft.EntityFrameworkCore;

namespace Flexischools.Data.Mappings
{
    internal class EntityMapper
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LectureMap());
            modelBuilder.ApplyConfiguration(new LectureTheatreMap());
            modelBuilder.ApplyConfiguration(new StudentMap());
            modelBuilder.ApplyConfiguration(new SubjectMap());
        }
    }
}
