namespace Domain.Entities;

public class LessonMark
{
    public Guid Id { get; set; }

    public required Guid StudentId { get; set; }

    public required Guid LessonId { get; set; }

    public required uint Value { get; set; }
}