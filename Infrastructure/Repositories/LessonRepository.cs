using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;

using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class LessonRepository(AppDbContext dbContext) : ILessonRepository
{
    public Lesson GetLesson(Guid id)
    {
        return dbContext.Lessons
                   .AsNoTracking()
                   .Include(x => x.Group)
                   .Include(x => x.Teacher)
                   .Include(x => x.StudyRoom)
                   .FirstOrDefault(x => x.Id == id)
               ?? throw new NotFoundException($"Урок с id: {id} не найден");
    }

    public IReadOnlyList<Lesson> GetGroupLessons(
        Guid groupId,
        DateOnly fromDate,
        DateOnly toDate,
        TimeOnly fromTime,
        TimeOnly toTime)
    {
        return dbContext.Lessons
            .AsNoTracking()
            .Where(x =>
                x.GroupId == groupId
                && x.Date >= fromDate
                && x.Date <= toDate
                && x.StartTime >= fromTime
                && x.EndTime <= toTime
            )
            .Include(x => x.Group)
            .Include(x => x.Teacher)
            .Include(x => x.StudyRoom)
            .ToList();
    }

    public void CreateLesson(Lesson lesson)
    {
        dbContext.Lessons.Add(lesson);
        dbContext.SaveChanges();
    }

    public void CreateMark(LessonMark mark)
    {
        var lesson = dbContext.Lessons
                         .Include(x => x.Marks)
                         .FirstOrDefault(x => x.Id == mark.LessonId)
                     ?? throw new NotFoundException($"Урок с id: {mark.LessonId} не найден");

        lesson.Marks.Add(mark);
        dbContext.SaveChanges();
    }
}