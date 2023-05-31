using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlite<StudentSystemContext>("Data Source=StudentSystem.db");

var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();