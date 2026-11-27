namespace Domain.Entities;

public class Group
{
    public required Guid Id { get; set; }

    public required Guid TeacherId { get; set; }

    public Teacher Teacher { get; set; } = null!;

    public required Guid SubjectId { get; set; }

    public Subject Subject { get; set; } = null!;

    public required string Name { get; set; }

    public IList<Student> Students { get; set; } = null!;
}