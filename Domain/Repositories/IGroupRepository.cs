using Domain.Entities;

namespace Domain.Repositories;

public interface IGroupRepository
{
    Group GetGroup(Guid id);

    IReadOnlyList<Group> GetGroups();

    void CreateGroup(Group group);
}