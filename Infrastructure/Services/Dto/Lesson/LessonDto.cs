namespace Infrastructure.Services.Dto.Lesson;

public class LessonDto
{
    public required Guid Id { get; init; }

    public required Guid TeacherId { get; init; }

    public required Guid GroupId { get; init; }

    public required Guid StudyRoomId { get; init; }

    public required Guid PeriodId { get; init; }

    public required string Topic { get; init; }

    public required string HomeworkText { get; init; }

    public required DateOnly Date { get; init; }

    public required TimeOnly StartTime { get; init; }

    public required TimeOnly EndTime { get; init; }
}