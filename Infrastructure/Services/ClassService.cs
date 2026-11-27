using Domain.Repositories;

using Infrastructure.IServices;
using Infrastructure.Services.Dto.Class;

namespace Infrastructure.Services;

public class ClassService(IClassRepository repository) : IClassService
{
    public ClassDto GetClass(Guid id)
    {
        var cl = repository.GetClass(id);

        return new()
        {
            Id = cl.Id,
            TeacherId = cl.TeacherId,
            SchoolId = cl.SchoolId,
            Grade = cl.Grade,
            Letter = cl.Letter,
        };
    }

    public void CreateClass(CreateClassDto dto)
    {
        repository.CreateClass(
            new()
            {
                Id = Guid.NewGuid(),
                TeacherId = dto.TeacherId,
                SchoolId = dto.SchoolId,
                Grade = dto.Grade,
                Letter = dto.Letter,
            });
    }
}