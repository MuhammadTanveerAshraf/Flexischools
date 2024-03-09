using Flexischools.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Flexischools.Data
{
    public class FlexischoolsDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public FlexischoolsDBContext(DbContextOptions<FlexischoolsDBContext> options, IConfiguration configuration)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<StudentLecture> StudentLectures { get; set; }
        public DbSet<LectureTheatre> LectureTheatres { get; set; }
    }
}
