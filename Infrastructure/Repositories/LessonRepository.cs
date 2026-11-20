using Domain.Entities;
using Domain.Repositories;

using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class LessonRepository(AppDbContext dbContext) : ILessonRepository
{
    public Lesson? GetLesson(Guid id)
    {
        return dbContext.Lessons
            .FirstOrDefault(x => x.Id == id);
    }
}