using Domain.Exceptions;

namespace Domain.Entities;

public class Lesson
{
    public Lesson(TimeOnly startTime, TimeOnly endTime)
    {
        if (startTime >= endTime)
        {
            throw new InvalidLessonException("Время начала урока должно быть меньше времени окончания");
        }

        StartTime = startTime;
        EndTime = endTime;
    }

    public required Guid Id { get; set; }

    public required Guid TeacherId { get; set; }

    public Teacher Teacher { get; set; } = null!;

    public required Guid GroupId { get; set; }

    public Group Group { get; set; } = null!;

    public required Guid StudyRoomId { get; set; }

    public StudyRoom StudyRoom { get; set; } = null!;

    public required Guid PeriodId { get; set; }

    public Period Period { get; set; } = null!;

    public required string Topic { get; set; }

    public required string HomeworkText { get; set; }

    public required DateOnly Date { get; set; }

    public required TimeOnly StartTime { get; init; }

    public required TimeOnly EndTime { get; init; }
}