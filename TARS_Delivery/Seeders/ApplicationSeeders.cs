using Microsoft.EntityFrameworkCore;

namespace TARS_Delivery.Seeders;

public class ApplicationSeeders
{
    public void OnModelSeeders(ModelBuilder modelBuilder)
    {
        // RoleSeeders(modelBuilder);
        new RoleSeeders(modelBuilder);
    }
}