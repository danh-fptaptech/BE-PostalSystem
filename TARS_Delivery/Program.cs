using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Repositories;
using TARS_Delivery.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBC")));

// Auto Dependency Injection
builder.Services.Scan(scan =>
    scan.FromAssemblyOf<IBranchRepository>().AddClasses().AsMatchingInterface().WithScopedLifetime());
builder.Services.Scan(scan => 
    scan.FromAssemblyOf<IBranchService>().AddClasses().AsMatchingInterface().WithScopedLifetime());

// Auto Mapper
builder.Services.AddAutoMapper(typeof(DtoProfile));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
