using Infrastructure.IServices;
using Infrastructure.IServices.Dto.Group;

using Microsoft.AspNetCore.Mvc;

namespace EDiary.Controllers;

[ApiController]
[Route("group")]
public class GroupController(IGroupService service) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public IActionResult GetGroup([FromRoute] Guid id)
    {
        return Ok(service.GetGroup(id));
    }

    [HttpGet]
    public IActionResult GetGroups()
    {
        return Ok(service.GetGroups());
    }

    [HttpPost]
    public IActionResult CreateGroup([FromBody] CreateGroupDto group)
    {
        service.CreateGroup(group);

        return Created();
    }
}