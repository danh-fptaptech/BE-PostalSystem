using Microsoft.EntityFrameworkCore;

namespace TARS_Delivery.Seeders;

public class ApplicationSeeders
{
    public void OnModelSeeders(ModelBuilder modelBuilder)
    {
        // RoleSeeders(modelBuilder);
        new BranchSeeders(modelBuilder);
        new UserSeeders(modelBuilder);
        new CustomerSeeder(modelBuilder);
        new EmployeeSeeders(modelBuilder);
        new FeeCustomSeeders(modelBuilder);
        new HistoryLogSeeders(modelBuilder);
        new ItemSeeders(modelBuilder);
        new LocationSeeders(modelBuilder);
        new PackageSeeders(modelBuilder);
        new PermissionSeeders(modelBuilder);
        new RoleSeeders(modelBuilder);
        new ServiceSeeders(modelBuilder);
        new BlogSeeders(modelBuilder);
        new ServiceTypeSeeders(modelBuilder);
        new RoleHasPermissionSeeders(modelBuilder);
        new GeneralSettingSeeders(modelBuilder);
    }
}