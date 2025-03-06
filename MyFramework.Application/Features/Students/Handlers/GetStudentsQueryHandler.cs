using MediatR;
using MyFramework.Application.Features.Students.Queries;
using MyFramework.Domain.Entities;

namespace MyFramework.Application.Features.Students.Handlers;

public class GetStudentsQueryHandler : IRequestHandler<GetStudentsQuery, List<Student>>
{
    public Task<List<Student>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult<List<Student>>([
            new Student("John Doe", "johndoe@example.com"),
            new Student("Jane Smith", "janesmith@example.com")
        ]);
    }
}