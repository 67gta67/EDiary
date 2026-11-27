using Infrastructure.IServices.Dto.Subject;

namespace Infrastructure.IServices;

public interface ISubjectService
{
    IReadOnlyList<SubjectDto> GetSubjects();

    void CreateSubject(CreateSubjectDto dto);
}