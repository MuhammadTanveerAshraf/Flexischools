using Flexischools.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flexischools.Data.Mappings
{
    internal class LectureTheatreMap : IEntityTypeConfiguration<LectureTheatre>
    {
        public void Configure(EntityTypeBuilder<LectureTheatre> builder)
        {
            builder.ToTable("LectureTheatres", "dbo");
            builder.HasKey(p => p.Id);
        }
    }
}
