using Cqrs.Domain.Companies.Entities;
using Cqrs.Domain.Departments.Entities;
using Cqrs.Domain.Employees.Entities;
using Cqrs.Domain.Entities;
using Cqrs.Domain.Projects.Entities;

namespace Cqrs.Domain.Data;
public static class InitialSeed
{
    public static IEnumerable<Company> GetCompanies()
    {
        return [
            new Company("Apple",
                        [new Department("Development",
                                                  City.NewYork,
                                                  [new Employee("John",
                                                                         new DateOnly(2024, 05, 05),
                                                                         null)],
                                                  [new Project("iPhone 16",
                                                                       15000000,
                                                                       new DateOnly(2024, 05,05),
                                                                       10)])]),
            new Company("Meta",
                        [new Department("Development",
                                                  City.NewYork,
                                                  [new Employee("Maria",
                                                                         new DateOnly(2024, 05, 05),
                                                                         null)],
                                                  [new Project("Metaverso",
                                                                       8000000,
                                                                       new DateOnly(2024, 05,05),
                                                                       10)])]),
            new Company("Google",
                        [new Department("Development",
                                                  City.NewYork,
                                                  [new Employee("Michael",
                                                                         new DateOnly(2024, 05, 05),
                                                                         null)],
                                                  [new Project("Android",
                                                                       20000000,
                                                                       new DateOnly(2024, 05, 05),
                                                                       15)])]),
            new Company("Microsoft",
                        [new Department("Development",
                                                  City.NewYork,
                                                  [new Employee("Sarah",
                                                                         new DateOnly(2024, 05, 05),
                                                                         null)],
                                                  [new Project("Windows 12",
                                                                       18000000,
                                                                       new DateOnly(2024, 05, 05),
                                                                       12)])])];
    }
}
