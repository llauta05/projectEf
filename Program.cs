using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectEf;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TasksContext>(p => p.UseInMemoryDatabase("tasksDb"));



var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbConection", async ([FromServices] TasksContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("base de datos en memoria: " + dbContext.Database.IsInMemory());
});


app.Run();
