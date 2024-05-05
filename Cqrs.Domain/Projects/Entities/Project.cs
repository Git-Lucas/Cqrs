namespace Cqrs.Domain.Projects.Entities;
public class Project : BaseEntity
{
    public string Code { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
    public decimal Budget { get; private set; }
    public DateOnly StartDate { get; private set; }
    public int WorkedHours { get; private set; }

    public Project(string code, string name, decimal budget, DateOnly startDate, int workedHours)
    {
        Code = code;
        Name = name;
        Budget = budget;
        StartDate = startDate;
        WorkedHours = workedHours;
    }

    public Project() { }
}
