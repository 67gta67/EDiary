using Infrastructure.IServices;
using Infrastructure.IServices.Dto.Class;

using Microsoft.AspNetCore.Mvc;

namespace EDiary.Controllers;

[ApiController]
[Route("class")]
public class ClassController(IClassService service) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public IActionResult GetClass([FromRoute] Guid id)
    {
        return Ok(service.GetClass(id));
    }

    [HttpPost]
    public IActionResult CreateClass([FromBody] CreateClassDto dto)
    {
        service.CreateClass(dto);

        return Created();
    }
}