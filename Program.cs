﻿using FestivalHue.Models;
using Microsoft.EntityFrameworkCore;
using FestivalHue.Controllers;
using FestivalHue.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
/*builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());*/
builder.Services.AddAutoMapper(typeof(ApplicationMapper));
builder.Services.AddDbContext<FestivalHueContext>(options => { 
    options.UseSqlServer(builder.Configuration.GetConnectionString("FestivalHue")); 
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
