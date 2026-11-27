using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;

using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GroupRepository(AppDbContext dbContext) : IGroupRepository
{
    public Group GetGroup(Guid id)
    {
        return dbContext.Groups
                   .AsNoTracking()
                   .FirstOrDefault(g => g.Id == id)
               ?? throw new NotFoundException($"Группа с id: {id} не найдена");
    }

    public IReadOnlyList<Group> GetGroups()
    {
        return dbContext.Groups
            .AsNoTracking()
            .ToList();
    }

    public void CreateGroup(Group group)
    {
        dbContext.Groups.Add(group);
        dbContext.SaveChanges();
    }
}