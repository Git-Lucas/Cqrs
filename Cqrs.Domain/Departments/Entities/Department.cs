using Cqrs.Domain.Employees.Entities;
using Cqrs.Domain.Entities;
using Cqrs.Domain.Projects.Entities;

namespace Cqrs.Domain.Departments.Entities;
public class Department : BaseEntity
{
    public string Code { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
    public City OfficeCity { get; set; }
    public IEnumerable<Employee> Employees { get; private set; } = [];
    public IEnumerable<Project> Projects { get; private set; } = [];

    public Department(string code, string name, IEnumerable<Employee> employees, IEnumerable<Project> projects)
    {
        Code = code;
        Name = name;
        Employees = employees;
        Projects = projects;
    }

    public Department() { }
}
