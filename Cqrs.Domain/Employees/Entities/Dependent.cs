using Cqrs.Domain.Employees.Enums;

namespace Cqrs.Domain.Employees.Entities;
public class Dependent : Person
{
    public TypeDependency Type { get; private set; }
    public short Age { get; private set; }

    public Dependent(string name, TypeDependency type, short age) : base(name)
    {
        Type = type;
        Age = age;
    }

    public Dependent() { }
}
