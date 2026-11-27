using Domain;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;

using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class TeacherRepository(AppDbContext dbContext) : ITeacherRepository
{
    public Teacher GetTeacher(Guid id)
    {
        return dbContext.Teachers
                   .AsNoTracking()
                   .FirstOrDefault(t => t.Id == id)
               ?? throw new NotFoundException($"Учитель с id: {id} не найден");
    }

    public IReadOnlyList<Teacher> GetTeachers()
    {
        return dbContext.Teachers
            .AsNoTracking()
            .ToList();
    }

    public void CreateTeacher(Teacher teacher)
    {
        dbContext.Teachers.Add(teacher);
        dbContext.SaveChanges();
    }
}