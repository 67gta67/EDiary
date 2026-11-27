using Infrastructure.Services.Dto.Class;

namespace Infrastructure.IServices;

public interface IClassService
{
    ClassDto GetClass(Guid id);

    void CreateClass(CreateClassDto dto);
}