using Domain.Entities;

namespace Domain.Repositories;

public interface ISubjectRepository
{
    IReadOnlyList<Subject> GetSubjects();

    void CreateSubject(Subject subject);
}