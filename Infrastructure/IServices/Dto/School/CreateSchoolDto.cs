namespace Infrastructure.IServices.Dto.School;

public class CreateSchoolDto
{
    public required string Name { get; init; }

    public required string Country { get; init; }

    public required string City { get; init; }

    public required string Street { get; init; }

    public required string Building { get; init; }
}