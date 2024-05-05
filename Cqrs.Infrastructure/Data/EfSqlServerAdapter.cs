using Cqrs.Domain.Companies.Entities;
using Cqrs.Domain.Departments.Entities;
using Cqrs.Domain.Employees.Entities;
using Cqrs.Domain.Projects.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cqrs.Infrastructure.Data;
public class EfSqlServerAdapter(DbContextOptions options) : DbContext(options)
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Project> Projects { get; set; }
}
