namespace Cqrs.Domain.Projects.Entities;
public class Project : BaseEntity
{
    public string Name { get; private set; } = string.Empty;
    public decimal Budget { get; private set; }
    public DateOnly StartDate { get; private set; }
    public int WorkedHours { get; private set; }

    public Project(string name, decimal budget, DateOnly startDate, int workedHours)
    {
        Name = name;
        Budget = budget;
        StartDate = startDate;
        WorkedHours = workedHours;
    }

    public Project() { }
}
