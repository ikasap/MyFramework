using MediatR;
using MyFramework.Domain.Entities;

namespace MyFramework.Application.Features.Students.Queries;

public class GetStudentsQuery : IRequest<List<Student>> { }