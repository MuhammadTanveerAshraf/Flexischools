using Flexischools.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flexischools.Data.Mappings
{
    internal class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students", "dbo");
            builder.HasKey(p => p.Id);

            builder.HasMany(s => s.Subjects)
                .WithMany(c => c.Students)
                .UsingEntity("StudentSubjects",
                l => l.HasOne(typeof(Student)).WithMany().HasForeignKey("StudentId").HasPrincipalKey(nameof(Student.Id)),
                r => r.HasOne(typeof(Subject)).WithMany().HasForeignKey("SubjectId").HasPrincipalKey(nameof(Subject.Id)),
                j => j.HasKey("StudentId", "SubjectId")
                );

            builder.HasMany(s => s.Lectures)
                .WithMany(c => c.Students)
                .UsingEntity("StudentLectures",
                l => l.HasOne(typeof(Student)).WithMany().HasForeignKey("StudentId").HasPrincipalKey(nameof(Student.Id)),
                r => r.HasOne(typeof(Lecture)).WithMany().HasForeignKey("LectureId").HasPrincipalKey(nameof(Lecture.Id)),
                j => j.HasKey("StudentId", "LectureId")
                );
        }
    }
}
