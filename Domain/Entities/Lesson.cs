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

    public required Teacher Teacher { get; set; }

    public required Guid GroupId { get; set; }

    public required Group Group { get; set; }

    public required Guid StudyRoomId { get; set; }

    public required StudyRoom StudyRoom { get; set; }

    public required Guid PeriodId { get; set; }

    public required Period Period { get; set; }

    public required string Topic { get; set; }

    public required string HomeworkText { get; set; }

    public required DateOnly Date { get; set; }

    public required TimeOnly StartTime { get; init; }

    public required TimeOnly EndTime { get; init; }
}