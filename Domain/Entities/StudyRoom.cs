namespace Domain;

public class StudyRoom
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public required Guid SchoolId { get; set; }
}