using Domain.Entities;

namespace Domain.Repositories;

public interface ILessonRepository
{
    Lesson? GetLesson(Guid id);
}