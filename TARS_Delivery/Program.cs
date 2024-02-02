using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Scrutor;
using TARS_Delivery;
using TARS_Delivery.Extensions;
using TARS_Delivery.Models;
using TARS_Delivery.Repositories;
using TARS_Delivery.Services;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DBC")));

// Auto Dependency Injection
builder.Services.Scan(scan =>
    scan.FromAssemblyOf<IBranchRepository>().AddClasses().AsMatchingInterface().WithScopedLifetime());
builder.Services.Scan(scan => 
    scan.FromAssemblyOf<IBranchService>().AddClasses().AsMatchingInterface().WithScopedLifetime());

// scurtor register all services
builder.Services.Scan(selector =>
    // transient
    selector.FromAssemblies(AssemblyReference.Assembly)
        .AddClasses(action => action.InNamespaces("TARS_Delivery.Providers"), false)
        .AsMatchingInterface()
        .WithTransientLifetime()
    
    //scoped
        .FromAssemblies(AssemblyReference.Assembly)
        .AddClasses(false)
        .UsingRegistrationStrategy(RegistrationStrategy.Skip)
        .AsMatchingInterface()
        .WithScopedLifetime());

// mediatr
builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssemblies(
        AssemblyReference.Assembly));

// Auto Mapper
builder.Services.AddAutoMapper(typeof(DtoProfile));

//authentication and authorization
builder.Services.ConfigureJwtSetup(configuration);
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer();

//builder.Services.AddAuthorization();

// configure options binding


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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
