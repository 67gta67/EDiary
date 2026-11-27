namespace Infrastructure.IServices.Dto.Group;

public class CreateGroupDto
{
    public required Guid TeacherId { get; set; }

    public required Guid SubjectId { get; set; }

    public required string Name { get; set; }
}