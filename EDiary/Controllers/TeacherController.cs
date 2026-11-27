using Domain.Exceptions;

using Infrastructure.IServices;
using Infrastructure.Services.Dto.Teacher;

using Microsoft.AspNetCore.Mvc;

namespace EDiary.Controllers;

[ApiController]
[Route("teacher")]
public class TeacherController(ITeacherService service) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public IActionResult GetTeacher([FromRoute] Guid id)
    {
        try
        {
            return Ok(service.GetTeacher(id));
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpGet]
    public IActionResult GetTeachers()
    {
        return Ok(service.GetTeachers());
    }

    [HttpPost]
    public IActionResult CreateTeacher([FromBody] CreateTeacherDto teacher)
    {
        service.CreateTeacher(teacher);

        return Created();
    }
}