using Flexischools.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flexischools.Data.Mappings
{
    internal class LectureMap : IEntityTypeConfiguration<Lecture>
    {
        public void Configure(EntityTypeBuilder<Lecture> builder)
        {
            builder.ToTable("Lectures", "dbo");
            builder.HasKey(p => p.Id);

            builder.HasOne(x => x.LectureTheatre)
                .WithMany(x => x.Lectures)
                .HasForeignKey(x => x.LectureTheatreId);
        }
    }
}
