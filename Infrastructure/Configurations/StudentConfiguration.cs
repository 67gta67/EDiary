using Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable(nameof(Student));
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Class)
            .WithMany()
            .HasForeignKey(x => x.ClassId);
    }
}