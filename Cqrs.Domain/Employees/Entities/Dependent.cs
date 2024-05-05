using Cqrs.Domain.Employees.Enums;

namespace Cqrs.Domain.Employees.Entities;
public class Dependent : Person
{
    public TypeDependency Type { get; private set; }
    public short Age { get; private set; }

    public Dependent(string code, string name, TypeDependency type, short age) : base(code, name)
    {
        Type = type;
        Age = age;
    }

    public Dependent() { }
}
