namespace Domain.Entities;

public class Class
{
    public required Guid Id { get; set; }

    public required Guid SchoolId { get; set; }

    public required Guid TeacherId { get; set; }

    public required uint Grade { get; set; }

    public required char Letter { get; set; }
}