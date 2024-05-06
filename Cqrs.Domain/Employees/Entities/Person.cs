namespace Cqrs.Domain.Employees.Entities;
public abstract class Person : BaseEntity
{
    public string Name { get; private set; } = string.Empty;

    public Person(string name)
    {
        Name = name;
    }

    public Person() { }
}
