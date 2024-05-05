using Cqrs.Domain.Departments.Entities;

namespace Cqrs.Domain.Companies.Entities;
public class Company : BaseEntity
{
    public string Code { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
    public IEnumerable<Department> Departments { get; private set; } = [];

    public Company(string code, string name, IEnumerable<Department> departments)
    {
        Code = code;
        Name = name;
        Departments = departments;
    }

    public Company() { }
}
