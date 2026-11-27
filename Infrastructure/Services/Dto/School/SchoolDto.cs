namespace Infrastructure.Services.Dto.School;

public class SchoolDto
{
    public required Guid Id { get; init; }

    public required string Name { get; init; }

    public required string Country { get; init; }

    public required string City { get; init; }

    public required string Street { get; init; }

    public required string Building { get; init; }
}