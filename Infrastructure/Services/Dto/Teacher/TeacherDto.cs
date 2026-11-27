namespace Infrastructure.Services.Dto.Teacher;

public class TeacherDto
{
    public required Guid Id { get; init; }

    public required Guid SchoolId { get; init; }

    public required string FirstName { get; init; }

    public required string SecondName { get; init; }

    public required string LastName { get; init; }

    public required DateOnly BirthDate { get; init; }

    public required string Email { get; init; }

    public required string HashedPassword { get; init; }
}