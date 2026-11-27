using Domain;
using Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Teacher> Teachers => Set<Teacher>();

    public DbSet<Lesson> Lessons => Set<Lesson>();

    public DbSet<Student> Students => Set<Student>();

    public DbSet<School> Schools => Set<School>();

    public DbSet<Group> Groups => Set<Group>();

    public DbSet<Class> Classes => Set<Class>();

    public DbSet<Subject> Subjects => Set<Subject>();
}