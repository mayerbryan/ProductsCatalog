using ProductsCatalog.Data;
using Microsoft.EntityFrameworkCore;
using ProductsCatalog.Services;

var builder = WebApplication.CreateBuilder(args);

var server = builder.Configuration["DbServer"] ?? "localhost";
var port = builder.Configuration["DbPort"] ?? "1433";
var user = builder.Configuration["DbUser"] ?? "SA";
var password = builder.Configuration["Password"] ?? "P@ssword1234";
var database = builder.Configuration["Database"] ?? "ProductsCatalogDB";

var connectionString = $"Server={server}, {port}; Initial Catalog={database};User ID={user}; Password={password}";

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

DatabaseManagementService.MigrationInitialisation(app);

app.MapControllers();

app.Run();
