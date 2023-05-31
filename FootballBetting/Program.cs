using Microsoft.EntityFrameworkCore;
using FootballBetting.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlite<FootballBettingContext>("Data Source=FootballBetting.db");
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
