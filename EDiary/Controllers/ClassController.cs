using Domain.Exceptions;

using Infrastructure.IServices;
using Infrastructure.Services.Dto.Class;

using Microsoft.AspNetCore.Mvc;

namespace EDiary.Controllers;

[ApiController]
[Route("class")]
public class ClassController(IClassService service) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public IActionResult GetClass([FromRoute] Guid id)
    {
        try
        {
            return Ok(service.GetClass(id));
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpPost]
    public IActionResult CreateClass([FromBody] CreateClassDto dto)
    {
        service.CreateClass(dto);

        return Created();
    }
}