namespace Domain.Entities;

public class Student
{
    public required Guid Id { get; set; }

    public required Guid ClassId { get; set; }

    public Class Class { get; set; } = null!;

    public required string FirstName { get; set; }

    public required string SecondName { get; set; }

    public required string LastName { get; set; }

    public required DateOnly BirthDate { get; set; }

    public required string Login { get; set; }

    public required string HashedPassword { get; set; }

    public IList<Group> Groups { get; set; } = null!;
}