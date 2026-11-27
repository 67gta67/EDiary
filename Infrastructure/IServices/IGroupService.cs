using Infrastructure.IServices.Dto.Group;

namespace Infrastructure.IServices;

public interface IGroupService
{
    GroupDto GetGroup(Guid id);

    IReadOnlyList<GroupDto> GetGroups();

    void CreateGroup(CreateGroupDto dto);
}