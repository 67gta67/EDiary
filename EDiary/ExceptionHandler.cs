using Domain.Exceptions;

using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace EDiary;

public class ExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        (int statusCode, string message) = MapException(exception);

        httpContext.Response.StatusCode = statusCode;
        await httpContext.Response.WriteAsync(message, cancellationToken);

        return true;
    }

    private static (int StatusCode, string Message) MapException(Exception exception) => exception switch
    {
        NotFoundException => (404, exception.Message),
        InvalidLessonException => (400, exception.Message),
        DbUpdateException => (409, "Отсутствуют одна или более связанных сущностей"),
        _ => (500, exception.Message),
    };
}