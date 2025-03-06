using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyFramework.Application.Features.Students.Queries;
using MyFramework.Domain.Entities;

namespace MyFramework.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<Student>>> Get()
    {
        return await mediator.Send(new GetStudentsQuery());
    }
}