namespace Domain;

public class Teacher
{
    public required Guid Id { get; set; }

    public required Guid SchoolId { get; set; }

    public required string FirstName { get; set; }

    public required string SecondName { get; set; }

    public required string LastName { get; set; }

    public required DateOnly BirthDate { get; set; }

    public required string Email { get; set; }

    public required string HashedPassword { get; set; }
}