using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using TARS_Delivery.Models;
using TARS_Delivery.Repositories;
using TARS_Delivery.Repositories.imp;
using TARS_Delivery.Services;
using TARS_Delivery.Services.imp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBC")));

// Auto Dependency Injection
builder.Services.Scan(scan =>
    scan.FromAssemblyOf<IBranchRepository>().AddClasses().AsMatchingInterface().WithScopedLifetime());
builder.Services.Scan(scan => 
    scan.FromAssemblyOf<IBranchService>().AddClasses().AsMatchingInterface().WithScopedLifetime());

builder.Services.AddScoped<IItemInterface, ItemRepository>();
builder.Services.AddScoped<ItemService>();
// Auto Mapper
builder.Services.AddAutoMapper(typeof(DtoProfile));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
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
