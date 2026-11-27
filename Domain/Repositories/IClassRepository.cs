using Domain.Entities;

namespace Domain.Repositories;

public interface IClassRepository
{
    Class GetClass(Guid id);

    void CreateClass(Class c);
}