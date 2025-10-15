using GerenciadorDeVeiculos.Dominio.DTOs;
using GerenciadorDeVeiculos.Dominio.Interfaces;
using GerenciadorDeVeiculos.Dominio.ModelViews;
using GerenciadorDeVeiculos.Dominio.Servicos;
using GerenciadorDeVeiculos.Infraestrutura.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAdministradorServico, AdministradorServico>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbContexto>(options =>
{
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySql"))
    );
});

var app = builder.Build();


app.MapGet("/", () => Results.Json(new Home()));

app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministradorServico administradorServico ) =>
{
    if (administradorServico.Login(loginDTO) != null)
    {
        return Results.Ok("Login com sucesso!");
    }
    else
    {
        return Results.Unauthorized();
    }
});

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
