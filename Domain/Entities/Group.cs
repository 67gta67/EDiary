namespace Domain.Entities;

public class Group
{
    public required Guid Id { get; set; }

    public required Guid TeacherId { get; set; }

    public required Guid SubjectId { get; set; }

    public required string Name { get; set; }
}