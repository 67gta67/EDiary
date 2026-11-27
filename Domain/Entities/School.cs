namespace Domain.Entities;

public class School
{
    public required Guid Id { get; set; }

    public required string Name { get; set; }

    public required string Country { get; set; }

    public required string City { get; set; }

    public required string Street { get; set; }

    public required string Building { get; set; }
}