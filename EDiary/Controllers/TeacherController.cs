using Infrastructure.IServices;
using Infrastructure.IServices.Dto.Teacher;

using Microsoft.AspNetCore.Mvc;

namespace EDiary.Controllers;

[ApiController]
[Route("teacher")]
public class TeacherController(ITeacherService service) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public IActionResult GetTeacher([FromRoute] Guid id)
    {
        return Ok(service.GetTeacher(id));
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