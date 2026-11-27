using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;

using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class SchoolRepository(AppDbContext dbContext) : ISchoolRepository
{
    public School GetSchool(Guid id)
    {
        return dbContext.Schools
                   .FirstOrDefault(s => s.Id == id)
               ?? throw new NotFoundException($"Школа с id: {id} не найдена");
    }

    public IReadOnlyList<School> GetSchools()
    {
        return dbContext.Schools
            .AsNoTracking()
            .ToList();
    }

    public void CreateSchool(School school)
    {
        dbContext.Schools.Add(school);
        dbContext.SaveChanges();
    }
}