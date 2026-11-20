using Domain;
using Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Teacher> Teachers => Set<Teacher>();

    public DbSet<Lesson> Lessons => Set<Lesson>();

    // TODO: Temp
    // public DbSet<Student> Students => Set<Student>();
    //
    // public DbSet<School> Schools => Set<School>();
    //
    // public DbSet<Group> Group => Set<Group>();
    //

    // public DbSet<StudyRoom> StudyRooms => Set<StudyRoom>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseNpgsql(
            "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=postgres;CommandTimeout=10000");
    }
}