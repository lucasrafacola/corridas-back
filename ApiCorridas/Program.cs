using ApiCorridas.Repository;
using ApiCorridas.Repository.Interfaces;
using ApiCorridas.Services;
using ApiCorridas.Services.Interfaces;
using ApiCorridas.Services.Utils;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Adiciona classes de persistência
builder.Services.AddScoped<IPistasRepository, RepositorioPistas>();
builder.Services.AddScoped<ICompetidoresRepository, RepositorioCompetidores>();
builder.Services.AddScoped<IHistoricoCorridasRepository, RepositorioHistoricoCorridas>();

//Adiciona services
builder.Services.AddScoped<IPistasService, ServicoPistas>();
builder.Services.AddScoped<ICompetidoresService, ServicoCompetidores>();
builder.Services.AddScoped<IHistoricoCorridasService, ServicoHistoricoCorridas>();
builder.Services.AddScoped<IUtils, Utils>();

var connectionStringMySql = builder.Configuration.GetConnectionString("ConnectionMySql");
builder.Services.AddDbContext<APIDbContext>(x => x.UseMySql(connectionStringMySql, ServerVersion.Parse("8.0.27")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
