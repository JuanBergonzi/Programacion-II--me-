using WebVeterinaria.Logica.AnimalLogic;
using WebVeterinaria.Repositorios.Animal;
using WebVeterinaria.Logica.DuenioLogic;
using WebVeterinaria.Repositorios.Duenio;
using WebVeterinaria.Logica.AtencionLogic;
using WebVeterinaria.Repositorios.Atencion;
using WebVeterinaria.Logica.MedicamentoLogic;
using WebVeterinaria.Repositorios.Medicamento;
using WebVeterinaria.Logica.TipoAnimal;
using WebVeterinaria.Repositorios.TipoAnimal;
using Microsoft.EntityFrameworkCore;
using WebVeterinaria.Datos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IAnimalLogic, AnimalLogic>();
builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();

builder.Services.AddScoped<IDuenioLogic, DuenioLogic>();
builder.Services.AddScoped<IDuenioRepository, DuenioRepository>();

builder.Services.AddScoped<IAtencionLogic, AtencionLogic>();
builder.Services.AddScoped<IAtencionRepository, AtencionRepository>();
builder.Services.AddScoped<IMedicamentoLogic, MedicamentoLogic>();
builder.Services.AddScoped<IMedicamentoRepository, MedicamentoRepository>();
builder.Services.AddScoped<ITipoAnimalLogic, TipoAnimalLogic>();
builder.Services.AddScoped<ITipoAnimalRepository, TipoAnimalRepository>();
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("Connection");
builder.Services.AddDbContext<TodoContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5202); // HTTP
    options.ListenLocalhost(7005, listenOptions =>
    {
        listenOptions.UseHttps();
    });
});

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
