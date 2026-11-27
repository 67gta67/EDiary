using Domain.Exceptions;

using Infrastructure.IServices;
using Infrastructure.Services.Dto.School;

using Microsoft.AspNetCore.Mvc;

namespace EDiary.Controllers;

[ApiController]
[Route("school")]
public class SchoolController(ISchoolService service) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public IActionResult GetSchool([FromRoute] Guid id)
    {
        try
        {
            return Ok(service.GetSchool(id));
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpGet]
    public IActionResult GetSchools()
    {
        return Ok(service.GetSchools());
    }

    [HttpPost]
    public IActionResult CreateSchool(CreateSchoolDto dto)
    {
        service.CreateSchool(dto);
        return Created();
    }
}