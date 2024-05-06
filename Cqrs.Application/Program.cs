using Cqrs.Application;
using Cqrs.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new Exception("Unable to get the connection string.");
builder.Services.AddDbContext<EfSqlServerAdapter>(opt => 
    opt.UseSqlServer(connectionString));

var app = builder.Build();

IServiceScope scope = app.Services.CreateScope();
EfSqlServerAdapter context = scope.ServiceProvider.GetRequiredService<EfSqlServerAdapter>();
await context.Database.MigrateAsync();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () =>
{
    return Results.Ok("CQRS Running");
});

app.MapEndpointSeed();

app.Run();
