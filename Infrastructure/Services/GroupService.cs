using Domain.Repositories;

using Infrastructure.IServices;
using Infrastructure.IServices.Dto.Group;

namespace Infrastructure.Services;

public class GroupService(IGroupRepository repository) : IGroupService
{
    public GroupDto GetGroup(Guid id)
    {
        var group = repository.GetGroup(id);

        return new()
        {
            Id = group.Id, TeacherId = group.TeacherId, SubjectId = group.SubjectId, Name = group.Name,
        };
    }

    public IReadOnlyList<GroupDto> GetGroups()
    {
        return repository.GetGroups().Select(s =>
                new GroupDto() { Id = s.Id, TeacherId = s.TeacherId, SubjectId = s.SubjectId, Name = s.Name })
            .ToList();
    }

    public void CreateGroup(CreateGroupDto dto)
    {
        repository.CreateGroup(
            new() { Id = Guid.NewGuid(), TeacherId = dto.TeacherId, SubjectId = dto.SubjectId, Name = dto.Name });
    }
}