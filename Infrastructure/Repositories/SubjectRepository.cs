using Domain.Entities;
using Domain.Repositories;

using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class SubjectRepository(AppDbContext dbContext) : ISubjectRepository
{
    public IReadOnlyList<Subject> GetSubjects()
    {
        return dbContext.Subjects
            .AsNoTracking()
            .ToList();
    }

    public void CreateSubject(Subject subject)
    {
        dbContext.Subjects.Add(subject);
        dbContext.SaveChanges();
    }
}