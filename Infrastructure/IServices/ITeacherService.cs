using Infrastructure.Services.Dto.Teacher;

namespace Infrastructure.IServices;

public interface ITeacherService
{
    TeacherDto GetTeacher(Guid id);

    IReadOnlyList<TeacherDto> GetTeachers();

    void CreateTeacher(CreateTeacherDto dto);
}