using Domain.Repositories;

using Infrastructure.IServices;
using Infrastructure.IServices.Dto.School;

namespace Infrastructure.Services;

public class SchoolService(ISchoolRepository repository) : ISchoolService
{
    public SchoolDto GetSchool(Guid id)
    {
        var school = repository.GetSchool(id);

        return new()
        {
            Id = school.Id,
            Name = school.Name,
            Country = school.Country,
            City = school.City,
            Street = school.Street,
            Building = school.Building,
        };
    }

    public IReadOnlyList<SchoolDto> GetSchools()
    {
        var schools = repository.GetSchools();

        return schools.Select(s => new SchoolDto()
            {
                Id = s.Id,
                Name = s.Name,
                Country = s.Country,
                City = s.City,
                Street = s.Street,
                Building = s.Building,
            })
            .ToList();
    }

    public void CreateSchool(CreateSchoolDto school)
    {
        repository.CreateSchool(
            new()
            {
                Id = Guid.NewGuid(),
                Name = school.Name,
                Country = school.Country,
                City = school.City,
                Street = school.Street,
                Building = school.Building,
            });
    }
}