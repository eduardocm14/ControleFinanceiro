using Microsoft.EntityFrameworkCore;
using WebAPIControleFinanceiroCore.Data;
using IniParser;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Ler o arquivo INI e configurar a string de conexão
var parser = new IniDataParser();
var iniData = parser.Parse(File.ReadAllText("dbconfig.ini"));

var dbSettings = iniData["DatabaseSettings"];
string connectionString = $"Host={dbSettings["Host"]};Database={dbSettings["Database"]};Username={dbSettings["Username"]};Password={dbSettings["Password"]}";

// Adicionar serviços ao contêiner.
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
