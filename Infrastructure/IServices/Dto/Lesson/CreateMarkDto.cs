namespace Infrastructure.IServices.Dto.Lesson;

public class CreateMarkDto
{
    public required Guid StudentId { get; init; }

    public required uint Value { get; init; }
}