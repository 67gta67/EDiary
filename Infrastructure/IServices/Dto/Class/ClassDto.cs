namespace Infrastructure.IServices.Dto.Class;

public class ClassDto
{
    public required Guid Id { get; init; }

    public required Guid SchoolId { get; init; }

    public required Guid TeacherId { get; init; }

    public required uint Grade { get; init; }

    public required string Letter { get; init; }
}