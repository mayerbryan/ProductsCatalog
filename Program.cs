using ProductsCatalog.Data;
using Microsoft.EntityFrameworkCore;
using ProductsCatalog.Services;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();

var connectionString = $"Server={Environment.GetEnvironmentVariable("SERVER")}, {Environment.GetEnvironmentVariable("DATABASE_PORT")}; Initial Catalog={Environment.GetEnvironmentVariable("DATABASE_NAME")};User ID={Environment.GetEnvironmentVariable("DATABASE_USER")}; Password={Environment.GetEnvironmentVariable("DATABASE_PASSWORD")}";

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

DatabaseManagementService.MigrationInitialisation(app);


app.MapControllers();

app.Run();
