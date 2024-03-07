using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders
{
    public class HistoryLogSeeders
    {
        public HistoryLogSeeders (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HistoryLog>().HasData(
                new HistoryLog
                {
                    Id = 1,
                    PackageId = 1,
                    EmployeeId = 1,
                    Step = Models.Enums.EPackageStatus.WaitingForPickup,
                    HistoryNote = "Đang chờ lấy hàng",
                    Photos = "https://tars.com/photos/1",
                    ProcessStep = Models.Enums.EStep.Processing,
                    EmployeeIdNextStep = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = Models.Enums.EStatusData.Active
                },
                new HistoryLog
                {
                    Id = 2,
                    PackageId = 1,
                    EmployeeId = 2,
                    Step = Models.Enums.EPackageStatus.InTransit,
                    HistoryNote = "Đang chờ lấy hàng",
                    Photos = "https://tars.com/photos/2",
                    ProcessStep = Models.Enums.EStep.Processing,
                    EmployeeIdNextStep = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = Models.Enums.EStatusData.Active
                },
                new HistoryLog
                {
                    Id = 3,
                    PackageId = 2,
                    EmployeeId = 2,
                    Step = Models.Enums.EPackageStatus.WaitingForPickup,
                    HistoryNote = "Đang chờ lấy hàng",
                    Photos = "https://tars.com/photos/2",
                    ProcessStep = Models.Enums.EStep.Processing,
                    EmployeeIdNextStep = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = Models.Enums.EStatusData.Active
                }
            );
        }
    }
}
