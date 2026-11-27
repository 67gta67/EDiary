using Infrastructure.Services.Dto.Lesson;

namespace Infrastructure.IServices;

public interface ILessonService
{
    LessonDto GetLesson(Guid id);

    IReadOnlyList<LessonDto> GetGroupLessons(
        Guid groupId,
        DateOnly fromDate,
        DateOnly toDate,
        TimeOnly fromTime,
        TimeOnly toTime);

    void CreateLesson(CreateLessonDto dto);
}