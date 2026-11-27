using Domain.Repositories;

using Infrastructure.IServices;
using Infrastructure.Services.Dto.Lesson;

namespace Infrastructure.Services;

public class LessonService(ILessonRepository repository) : ILessonService
{
    public LessonDto GetLesson(Guid id)
    {
        var lesson = repository.GetLesson(id);

        return new()
        {
            Id = lesson.Id,
            TeacherId = lesson.TeacherId,
            GroupId = lesson.GroupId,
            StudyRoomId = lesson.StudyRoomId,
            PeriodId = lesson.PeriodId,
            Topic = lesson.Topic,
            HomeworkText = lesson.HomeworkText,
            Date = lesson.Date,
            StartTime = lesson.StartTime,
            EndTime = lesson.EndTime,
        };
    }

    public IReadOnlyList<LessonDto> GetGroupLessons(
        Guid groupId,
        DateOnly fromDate,
        DateOnly toDate,
        TimeOnly fromTime,
        TimeOnly toTime)
    {
        var lessons = repository.GetGroupLessons(groupId, fromDate, toDate, fromTime, toTime);

        return lessons.Select(s => new LessonDto()
            {
                Id = s.Id,
                TeacherId = s.TeacherId,
                GroupId = s.GroupId,
                StudyRoomId = s.StudyRoomId,
                PeriodId = s.PeriodId,
                Topic = s.Topic,
                HomeworkText = s.HomeworkText,
                Date = s.Date,
                StartTime = s.StartTime,
                EndTime = s.EndTime,
            })
            .ToList();
    }

    public void CreateLesson(CreateLessonDto dto)
    {
        repository.CreateLesson(
            new(dto.StartTime, dto.EndTime)
            {
                Id = Guid.NewGuid(),
                TeacherId = dto.TeacherId,
                GroupId = dto.GroupId,
                StudyRoomId = dto.StudyRoomId,
                PeriodId = dto.PeriodId,
                Topic = dto.Topic,
                HomeworkText = dto.HomeworkText,
                Date = dto.Date,
                StartTime = dto.StartTime,
                EndTime = dto.EndTime,
            });
    }
}