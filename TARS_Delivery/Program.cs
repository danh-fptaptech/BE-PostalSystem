using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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

// JSON Serializer
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<EmployeeService>();

builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<RoleService>();

builder.Services.AddScoped<IPermissionRepository, PermissionRepository>();
builder.Services.AddScoped<PermissionService>();



// Auto Dependency Injection
builder.Services.Scan(scan =>
    scan.FromAssemblyOf<IBranchRepository>().AddClasses().AsMatchingInterface().WithScopedLifetime());
builder.Services.Scan(scan => 
    scan.FromAssemblyOf<IBranchService>().AddClasses().AsMatchingInterface().WithScopedLifetime());
    /* Employee */
builder.Services.Scan(scan =>
    scan.FromAssemblyOf<IEmployeeRepository>().AddClasses().AsMatchingInterface().WithScopedLifetime());
builder.Services.Scan(scan =>
    scan.FromAssemblyOf<IEmployeeService>().AddClasses().AsMatchingInterface().WithScopedLifetime());
    /* Role */
builder.Services.Scan(scan =>
    scan.FromAssemblyOf<IRoleRepository>().AddClasses().AsMatchingInterface().WithScopedLifetime());
builder.Services.Scan(scan =>
    scan.FromAssemblyOf<IRoleService>().AddClasses().AsMatchingInterface().WithScopedLifetime());
    /* Permission */
builder.Services.Scan(scan =>
    scan.FromAssemblyOf<IPermissionRepository>().AddClasses().AsMatchingInterface().WithScopedLifetime());
builder.Services.Scan(scan =>
    scan.FromAssemblyOf<IPermissionService>().AddClasses().AsMatchingInterface().WithScopedLifetime());

// JSON Serializer
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});


// Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder
           .AllowAnyMethod()
                  .AllowAnyHeader()
                         .SetIsOriginAllowed((host) => true)
                                .AllowCredentials());
});
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

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
