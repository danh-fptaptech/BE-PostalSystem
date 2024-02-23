using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Quartz;
using Scrutor;
using TARS_Delivery;
using TARS_Delivery.BackgroundJobs;
using TARS_Delivery.Behaviors;
using TARS_Delivery.Extensions;
using TARS_Delivery.Models;
using TARS_Delivery.Repositories;
using TARS_Delivery.Services;
using TARS_Delivery.Shared;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DBC")));

// Auto Dependency Injection
builder.Services.Scan(scan =>
    scan.FromAssemblyOf<IBranchRepository>().AddClasses(action => action.NotInNamespaces("TARS_Delivery.Shared")).AsMatchingInterface().WithScopedLifetime());
builder.Services.Scan(scan => 
    scan.FromAssemblyOf<IBranchService>().AddClasses(action => action.NotInNamespaces("TARS_Delivery.Shared")).AsMatchingInterface().WithScopedLifetime());

// scurtor register all services
builder.Services.Scan(selector =>
    // transient
    selector.FromAssemblies(AssemblyReference.Assembly)
        .AddClasses(action => action.InNamespaces("TARS_Delivery.Providers"), false)
        .AsMatchingInterface()
        .WithTransientLifetime()
    
    //scoped
        .FromAssemblies(AssemblyReference.Assembly)
        .AddClasses(action => action.NotInNamespaces("TARS_Delivery.Shared"), false)
        .UsingRegistrationStrategy(RegistrationStrategy.Skip)
        .AsMatchingInterface()
        .WithScopedLifetime());

// mediatr
builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssemblies(
        AssemblyReference.Assembly));

//validation
builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

builder.Services.AddValidatorsFromAssembly(AssemblyReference.Assembly, includeInternalTypes: true);

// Auto Mapper
builder.Services.AddAutoMapper(typeof(DtoProfile));

//authentication and authorization
builder.Services.ConfigureJwtSetup(configuration);
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer();

builder.Services.AddHttpContextAccessor();

// mail
builder.Services.ConfigureMailSetup(configuration);

// jobs
builder.Services.AddQuartz(cfg =>
{
    JobKey jobKey = new(nameof(ClearUserRegistrationJob));

    cfg.AddJob<ClearUserRegistrationJob>(jobKey)
        .AddTrigger(cfg =>
            cfg.ForJob(jobKey)
                .WithSimpleSchedule(
                    schedule => schedule.WithIntervalInHours(12)
                        .RepeatForever()));
});

builder.Services.AddQuartzHostedService();
// configure options binding


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
