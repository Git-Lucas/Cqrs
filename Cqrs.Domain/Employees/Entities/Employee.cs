namespace Cqrs.Domain.Employees.Entities;
public class Employee : Person
{
    public DateOnly AdmissionDate { get; private set; }
    public IEnumerable<Dependent> Dependents { get; private set; } = [];

    public Employee(string code, string name, DateOnly admissionDate, IEnumerable<Dependent> dependents) : base(code, name)
    {
        AdmissionDate = admissionDate;
        Dependents = dependents;
    }

    public Employee() { }
}
