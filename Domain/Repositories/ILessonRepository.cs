using Domain.Entities;

namespace Domain.Repositories;

public interface ILessonRepository
{
    Lesson GetLesson(Guid id);

    IReadOnlyList<Lesson> GetGroupLessons(
        Guid groupId,
        DateOnly fromDate,
        DateOnly toDate,
        TimeOnly fromTime,
        TimeOnly toTime);

    void CreateLesson(Lesson lesson);

    void CreateMark(LessonMark mark);
}