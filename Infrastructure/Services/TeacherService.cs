using Domain;
using Domain.Repositories;

using Infrastructure.Services.Dto;

namespace Infrastructure.Services;

public class TeacherService(ITeacherRepository repository)
{
    public TeacherDto? GetTeacher(Guid id)
    {
        var teacher = repository.GetTeacher(id);

        return teacher != null
            ? new()
            {
                Id = teacher.Id,
                SchoolId = teacher.SchoolId,
                FirstName = teacher.FirstName,
                SecondName = teacher.SecondName,
                LastName = teacher.LastName,
                Email = teacher.Email,
                HashedPassword = teacher.HashedPassword,
                BirthDate = teacher.BirthDate,
            }
            : null;
    }

    public void CreateTeacher(TeacherDto dto)
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