using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;

namespace Infrastructure.Repositories;

public class ClassRepository(AppDbContext dbContext) : IClassRepository
{
    public Class GetClass(Guid id)
    {
        return dbContext.Classes
                   .FirstOrDefault(c => c.Id == id)
               ?? throw new NotFoundException($"Класс с id: {id} не найден");
    }

    public void CreateClass(Class c)
    {
        dbContext.Classes.Add(c);
        dbContext.SaveChanges();
    }
}