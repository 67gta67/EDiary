using Domain;
using Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

internal class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.ToTable(nameof(Teacher));
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.School)
            .WithMany()
            .HasForeignKey(x => x.SchoolId);
    }
}