using Infrastructure.IServices.Dto.School;

namespace Infrastructure.IServices;

public interface ISchoolService
{
    SchoolDto GetSchool(Guid id);

    IReadOnlyList<SchoolDto> GetSchools();

    void CreateSchool(CreateSchoolDto dto);
}