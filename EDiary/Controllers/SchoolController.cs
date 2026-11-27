using Infrastructure.IServices;
using Infrastructure.IServices.Dto.School;

using Microsoft.AspNetCore.Mvc;

namespace EDiary.Controllers;

[ApiController]
[Route("school")]
public class SchoolController(ISchoolService service) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public IActionResult GetSchool([FromRoute] Guid id)
    {
        return Ok(service.GetSchool(id));
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