using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;
using TARS_Delivery.Models;
using TARS_Delivery.Models.Entities;
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

// Auto Mapper
builder.Services.AddAutoMapper(typeof(DtoProfile));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateIssuerSigningKey = true,
                //IssuerSigningKey duoc tao tu mot chuoi bi mat
                //dam bao rang chi nhung token duoc ky boi server cua ban moi duoc
                //he thong cham nhan
                IssuerSigningKey = new SymmetricSecurityKey
                (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
            };
        });

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

app.UseAuthorization();

app.MapControllers();

app.Run();
