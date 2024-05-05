namespace Cqrs.Domain.Employees.Entities;
public abstract class Person : BaseEntity
{
    public string Code { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;

    public Person(string code, string name)
    {
        Code = code;
        Name = name;
    }

    public Person() { }
}
