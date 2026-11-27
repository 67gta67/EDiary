using Domain.Exceptions;

using Infrastructure.IServices;
using Infrastructure.Services.Dto.Lesson;

using Microsoft.AspNetCore.Mvc;

namespace EDiary.Controllers;

[ApiController]
[Route("lesson")]
public class LessonController(ILessonService service) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public IActionResult GetLesson([FromRoute] Guid id)
    {
        try
        {
            return Ok(service.GetLesson(id));
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpGet]
    public IActionResult GetGroupLessons(
        [FromQuery] Guid groupId,
        [FromQuery] DateOnly fromDate,
        [FromQuery] DateOnly toDate,
        [FromQuery] TimeOnly fromTime,
        [FromQuery] TimeOnly toTime
    )
    {
        return Ok(service.GetGroupLessons(groupId, fromDate, toDate, fromTime, toTime));
    }

    [HttpPost]
    public IActionResult CreateLesson([FromBody] CreateLessonDto dto)
    {
        try
        {
            service.CreateLesson(dto);

            return Created();
        }
        catch (InvalidLessonException e)
        {
            return BadRequest(e.Message);
        }
    }
}