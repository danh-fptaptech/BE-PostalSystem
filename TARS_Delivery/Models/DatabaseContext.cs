using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Seeders;

namespace TARS_Delivery.Models;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   
        base.OnModelCreating(modelBuilder);

        #region ModelBuilder for FeeCustom

        modelBuilder.Entity<FeeCustom>()
            .HasOne<Location>(fc => fc.LocationTo)
            .WithMany()
            .HasForeignKey(fc => fc.LocationIdTo)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<FeeCustom>()
            .HasOne<Location>(fc => fc.LocationFrom)
            .WithMany()
            .HasForeignKey(fc=>fc.LocationIdFrom)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<FeeCustom>()
            .HasOne<Service>(fc => fc.Service)
            .WithMany()
            .HasForeignKey(fc => fc.ServiceId)
            .OnDelete(DeleteBehavior.Restrict);            
        #endregion

        #region ModelBuilder for Location
        
        modelBuilder.Entity<Location>()
            .HasOne<Location>(l => l.ParentLocation)
            .WithMany(l=>l.ChildLocations)
            .HasForeignKey(l=>l.LocationOf)
            .OnDelete(DeleteBehavior.Restrict);
        
        #endregion

        #region ModelBuilder for HistoryLog

        modelBuilder.Entity<HistoryLog>()
            .HasOne<Employee>(hl => hl.Employee)
            .WithMany(e=>e.HistoryLogs)
            .HasForeignKey(hl=>hl.EmployeeId);
        modelBuilder.Entity<HistoryLog>()
            .HasOne<Package>(hl => hl.Package)
            .WithMany(p=>p.HistoryLogs)
            .HasForeignKey(hl=>hl.PackageId);

        #endregion

        #region ModelBuilder for Item

        modelBuilder.Entity<Item>()
            .HasOne<Package>(i => i.Package)
            .WithMany(p=>p.Items)
            .HasForeignKey(i=>i.PackageId)
            .OnDelete(DeleteBehavior.Restrict);
        
        #endregion

        #region ModelBuilder for Package
        
        modelBuilder.Entity<Package>()
            .HasOne<User>(p => p.User)
            .WithMany(u=>u.Packages)
            .HasForeignKey(p=>p.UserId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Package>()
            .HasOne<FeeCustom>(p => p.FeeCustom)
            .WithMany()
            .HasForeignKey(p => p.FeeCustomId)
            .OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region ModelBuilder for RoleHasPermission

        modelBuilder.Entity<RoleHasPermission>()
            .HasKey(rhp => new { rhp.RoleId, rhp.PermissionId });
        modelBuilder.Entity<RoleHasPermission>()
            .HasOne<Role>(rhp=>rhp.Role)
            .WithMany(r => r.RoleHasPermissions)
            .HasForeignKey(rhp => rhp.RoleId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<RoleHasPermission>()
            .HasOne<Permission>(rhp => rhp.Permission)
            .WithMany()
            .HasForeignKey(rhp => rhp.PermissionId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region ModelBuilder for Employee

        modelBuilder.Entity<Employee>()
            .HasOne<Branch>(e => e.Branch)
            .WithMany(b=>b.Employees)
            .HasForeignKey(e=>e.BranchId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Employee>()
            .HasOne<Role>(e => e.Role)
            .WithMany()
            .HasForeignKey(e=>e.RoleId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region ModelBuilder for User

        modelBuilder.Entity<User>()
            .HasMany<Customer>(u=>u.Customers)
            .WithOne(c=>c.User)
            .HasForeignKey(c=>c.UserId);

        #endregion

        #region ModelBuilder Unique

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Phone)
            .IsUnique();
        modelBuilder.Entity<Employee>()
            .HasIndex(e => e.EmployeeCode)
            .IsUnique();
        modelBuilder.Entity<Package>()
            .HasIndex(p => p.TrackingCode)
            .IsUnique();

        #endregion

        #region ModelBuilder Service
        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasOne(d => d.ServiceType) 
                .WithMany(p => p.Services) 
                .HasForeignKey(d => d.ServiceTypeId) 
                .OnDelete(DeleteBehavior.Restrict);
        });
        #endregion

        #region modelBuilder for Seeders

        new ApplicationSeeders().OnModelSeeders(modelBuilder);

        #endregion

        #region ModelBuilder for Blog
        modelBuilder.Entity<Blog>()
            .HasOne<Employee>(b => b.Employee)
            .WithMany(e=>e.Blogs)
            .HasForeignKey(b=>b.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region ModelBuilder for SupportTicket
        modelBuilder.Entity<SupportTicket>()
            .HasOne<Employee>(st => st.Employee)
            .WithMany(e=>e.SupportTickets)
            .HasForeignKey(st=>st.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<SupportTicket>()
            .HasOne<User>(st => st.User)
            .WithMany(u=>u.SupportTickets)
            .HasForeignKey(st=>st.UserId)
            .OnDelete(DeleteBehavior.Restrict);
        #endregion
    }

    #region DbSet

    public DbSet<Branch> Branches { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<FeeCustom> FeeCustoms { get; set; }
    public DbSet<GeneralSetting> GeneralSettings { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RoleHasPermission> RoleHasPermissions { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<ServiceType> ServiceTypes { get; set; }
    public DbSet<HistoryLog> HistoryLogs { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Package> Packages { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<UserRegistrationInfo> UserRegistrations { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<SupportTicket> SupportTickets { get; set; }
    #endregion


}