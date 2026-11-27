namespace Domain.Entities;

public class Class
{
    public required Guid Id { get; set; }

    public required Guid SchoolId { get; set; }

    public School School { get; set; } = null!;

    public required Guid TeacherId { get; set; }

    public Teacher Teacher { get; set; } = null!;

    public required uint Grade { get; set; }

    public required string Letter { get; set; }
}