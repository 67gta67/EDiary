using Domain.Entities;
using Domain.Repositories;

using Infrastructure.IServices;
using Infrastructure.Services.Dto;
using Infrastructure.Services.Dto.Teacher;

namespace Infrastructure.Services;

public class TeacherService(ITeacherRepository repository) : ITeacherService
{
    public TeacherDto GetTeacher(Guid id)
    {
        var teacher = repository.GetTeacher(id);

        return new()
        {
            Id = teacher.Id,
            SchoolId = teacher.SchoolId,
            FirstName = teacher.FirstName,
            SecondName = teacher.SecondName,
            LastName = teacher.LastName,
            Email = teacher.Email,
            HashedPassword = teacher.HashedPassword,
            BirthDate = teacher.BirthDate,
        };
    }

    public IReadOnlyList<TeacherDto> GetTeachers()
    {
        var teachers = repository.GetTeachers();

        return teachers.Select(s => new TeacherDto()
            {
                Id = s.Id,
                SchoolId = s.SchoolId,
                FirstName = s.FirstName,
                SecondName = s.SecondName,
                LastName = s.LastName,
                Email = s.Email,
                HashedPassword = s.HashedPassword,
                BirthDate = s.BirthDate,
            })
            .ToList();
    }

    public void CreateTeacher(CreateTeacherDto dto)
    {
        Teacher teacher = new()
        {
            Id = Guid.NewGuid(),
            SchoolId = dto.SchoolId,
            FirstName = dto.FirstName,
            SecondName = dto.SecondName,
            LastName = dto.LastName,
            BirthDate = dto.BirthDate,
            Email = dto.Email,
            HashedPassword = dto.HashedPassword,
        };

        repository.CreateTeacher(teacher);
    }
}