using Domain.Entities;
using Domain.Repositories;

using Infrastructure.IServices;
using Infrastructure.IServices.Dto.Subject;

namespace Infrastructure.Services;

public class SubjectService(ISubjectRepository repository) : ISubjectService
{
    public IReadOnlyList<SubjectDto> GetSubjects()
    {
        return repository.GetSubjects()
            .Select(s => new SubjectDto() { Id = s.Id, Name = s.Name, })
            .ToList();
    }

    public void CreateSubject(CreateSubjectDto dto)
    {
        repository.CreateSubject(new Subject() { Id = Guid.NewGuid(), Name = dto.Name, });
    }
}