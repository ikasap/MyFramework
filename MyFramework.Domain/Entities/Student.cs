using MyFramework.Domain.Common;

namespace MyFramework.Domain.Entities;

public class Student(string name, string email) : BaseEntity
{
    public string Name { get; private set; } = name;
    public string Email { get; private set; } = email;
}