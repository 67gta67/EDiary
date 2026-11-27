using Infrastructure.IServices;
using Infrastructure.IServices.Dto.Lesson;

using Microsoft.AspNetCore.Mvc;

namespace EDiary.Controllers;

[ApiController]
[Route("lesson")]
public class LessonController(ILessonService service) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public IActionResult GetLesson([FromRoute] Guid id)
    {
        return Ok(service.GetLesson(id));
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
        service.CreateLesson(dto);

        return Created();
    }

    [HttpPost("{lessonId:guid}/mark")]
    public IActionResult CreateMark([FromRoute] Guid lessonId, [FromBody] CreateMarkDto dto)
    {
        service.CreateMark(lessonId, dto);
        return Created();
    }
}