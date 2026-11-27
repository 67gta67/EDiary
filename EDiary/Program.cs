using Domain.Repositories;

using EDiary;

using Infrastructure;
using Infrastructure.IServices;
using Infrastructure.Repositories;
using Infrastructure.Services;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddExceptionHandler<ExceptionHandler>();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("EDiaryDatabase"));
});

builder.Services.AddScoped<IClassRepository, ClassRepository>();
builder.Services.AddScoped<ILessonRepository, LessonRepository>();
builder.Services.AddScoped<ISchoolRepository, SchoolRepository>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<IGroupRepository, GroupRepository>();
builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();

builder.Services.AddScoped<IClassService, ClassService>();
builder.Services.AddScoped<ILessonService, LessonService>();
builder.Services.AddScoped<ISchoolService, SchoolService>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddScoped<IGroupService, GroupService>();
builder.Services.AddScoped<ISubjectService, SubjectService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger(c => c.OpenApiVersion = Microsoft.OpenApi.OpenApiSpecVersion.OpenApi2_0);
    app.UseSwaggerUI();
    app.UseExceptionHandler("/Error");
}

using var serviceScope = app.Services.CreateScope();
var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
context.Database.Migrate();

app.UseAuthorization();

app.MapControllers();

app.Run();