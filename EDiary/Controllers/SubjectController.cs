using Infrastructure.IServices;
using Infrastructure.IServices.Dto.School;
using Infrastructure.IServices.Dto.Subject;

using Microsoft.AspNetCore.Mvc;

namespace EDiary.Controllers;

[ApiController]
[Route("subject")]
public class SubjectController(ISubjectService service) : ControllerBase
{
    [HttpGet]
    public IActionResult GetSubjects()
    {
        return Ok(service.GetSubjects());
    }

    [HttpPost]
    public IActionResult CreateSubject([FromBody] CreateSubjectDto dto)
    {
        service.CreateSubject(dto);

        return Created();
    }
}