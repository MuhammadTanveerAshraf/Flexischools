using Flexischools.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flexischools.Data.Mappings
{
    internal class SubjectMap : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("Subjects", "dbo");
            builder.HasKey(p => p.Id);
        }
    }
}
