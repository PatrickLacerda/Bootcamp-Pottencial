using API.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// esta adicionando um dbcontext do tipo AgendaContext e passando algumas opções, 
// Utiliza SQL server, se fosse mysql, seria UseMysql, build.configurations está pegando configuração do 
//appsettings e estou pegando o nome da conexão que é conexão padrão 
//GetConnectionString("ConexãoPadrao"))); acessando a chave ConectionsStrings
// tudo que for apenas configuração você vai armazenar do seu arquivo.json
// inclusive conexão com obanco.

builder.Services.AddDbContext<AgendaContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConexãoPadrão")));



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
