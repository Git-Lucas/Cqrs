using Cqrs.Domain.Companies.Entities;
using Cqrs.Domain.Data;
using Cqrs.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cqrs.Application;

public static class Extensions
{
    public static WebApplication MapEndpointSeed(this WebApplication app)
    {
        app.MapGet("/dataToSeed", () =>
        {
            IEnumerable<Company> companiesToSeed = InitialSeed.GetCompanies();
            return Results.Ok(companiesToSeed);
        });
        app.MapPost("/seed", async ([FromServices] EfSqlServerAdapter context) =>
        {
            IEnumerable<Company> companiesToSeed = InitialSeed.GetCompanies();
            await context.Companies.AddRangeAsync(companiesToSeed);
            await context.SaveChangesAsync();

            return Results.Created(string.Empty, $"Seeded {companiesToSeed.Count()} {nameof(Company)}'s");
        });

        return app;
    }
}
