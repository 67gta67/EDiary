using Domain.Entities;

namespace Domain.Repositories;

public interface ISchoolRepository
{
    School GetSchool(Guid id);

    IReadOnlyList<School> GetSchools();

    void CreateSchool(School school);
}