namespace Domain.Entities;

public class Period
{
    public required Guid Id { get; set; }

    public required string Name { get; set; }

    public required DateOnly StartDate { get; set; }

    public required DateOnly EndDate { get; set; }
}