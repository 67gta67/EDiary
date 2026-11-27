using Domain.Entities;

namespace Domain.Repositories;

public interface ITeacherRepository
{
    Teacher GetTeacher(Guid id);

    IReadOnlyList<Teacher> GetTeachers();

    void CreateTeacher(Teacher teacher);
}