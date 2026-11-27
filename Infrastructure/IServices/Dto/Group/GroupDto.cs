namespace Infrastructure.IServices.Dto.Group;

public class GroupDto
{
    public required Guid Id { get; set; }

    public required Guid TeacherId { get; set; }

    public required Guid SubjectId { get; set; }

    public required string Name { get; set; }
}