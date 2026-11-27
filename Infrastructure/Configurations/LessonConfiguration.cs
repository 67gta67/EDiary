using Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

internal class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.ToTable(nameof(Lesson));
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Teacher)
            .WithMany()
            .HasForeignKey(x => x.TeacherId);

        builder.HasOne(x => x.Group)
            .WithMany()
            .HasForeignKey(x => x.GroupId);

        builder.HasOne(x => x.StudyRoom)
            .WithMany()
            .HasForeignKey(x => x.StudyRoomId);

        builder.HasOne(x => x.Period)
            .WithMany()
            .HasForeignKey(x => x.PeriodId);

        builder.HasMany(x => x.Marks)
            .WithOne();
    }
}