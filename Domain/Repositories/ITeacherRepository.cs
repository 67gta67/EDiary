namespace Domain.Repositories;

public interface ITeacherRepository
{
    Teacher? GetTeacher(Guid id);

    void CreateTeacher(Teacher teacher);
}