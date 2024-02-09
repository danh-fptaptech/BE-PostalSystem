using Microsoft.EntityFrameworkCore;
using Quartz;
using TARS_Delivery.Models;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.BackgroundJobs;

[DisallowConcurrentExecution]
public class ClearUserRegistrationJob(
    DatabaseContext dbContext) : IJob
{
    private readonly DatabaseContext _dbContext = dbContext;

    public async Task Execute(IJobExecutionContext context)
    {
        List<UserRegistrationInfo> userInfoList = await _dbContext
            .UserRegistrations
            .Where(u => u.CreatedAt < DateTime.Now.AddMinutes(-3))
            .ToListAsync();

        _dbContext.UserRegistrations.RemoveRange(userInfoList);

        await _dbContext.SaveChangesAsync();
    }
}
