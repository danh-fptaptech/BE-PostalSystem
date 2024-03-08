using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders
{
    public class UserSeeders
    {
        public UserSeeders (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                User.Seed(1, "Nguyễn Văn User", "usera@usera.com", "0123456789", "UrJhrQz2cizazce+Ifxod0BDddgr/NZAUR8/wKSE+So=:GBCJfGC3Pr5rwuS1xAKnmA==:10000:SHA256"),
                User.Seed(2, "Trần Văn User", "quan768qa5@gmail.com", "0987654321", "UrJhrQz2cizazce+Ifxod0BDddgr/NZAUR8/wKSE+So=:GBCJfGC3Pr5rwuS1xAKnmA==:10000:SHA256"),
                User.Seed(3, "Lê Văn User", "userc@userc.com", "023023920392", "UrJhrQz2cizazce+Ifxod0BDddgr/NZAUR8/wKSE+So=:GBCJfGC3Pr5rwuS1xAKnmA==:10000:SHA256")
            );
        }
    }
}
