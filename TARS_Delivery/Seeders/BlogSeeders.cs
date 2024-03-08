using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Seeders
{
    public class BlogSeeders
    {
        public BlogSeeders (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Title = "TARS Delivery",
                    Slug = "tars-delivery",
                    Content = "TARS Delivery is a logistics company that provides delivery services.",
                    Author = "TARS",
                    Category = ECategory.Promotion,
                    EmployeeId = 1,
                    Status = EStatusData.Active
                },
                new Blog
                {
                    Id = 2,
                    Title = "TARS Delivery 2",
                    Slug = "tars-delivery-2",
                    Content = "TARS Delivery 2 is a logistics company that provides delivery services.",
                    Author = "TARS",
                    Category = ECategory.Guide,
                    EmployeeId = 1,
                    Status = EStatusData.Active
                },
                new Blog
                {
                    Id = 3,
                    Title = "TARS Delivery 3",
                    Slug = "tars-delivery-3",
                    Content = "TARS Delivery 3 is a logistics company that provides delivery services.",
                    Author = "TARS",
                    Category = ECategory.Promotion,
                    EmployeeId = 1,
                    Status = EStatusData.Active
                },
                new Blog
                {
                    Id = 4,
                    Title = "TARS Delivery 4",
                    Slug = "tars-delivery-4",
                    Content = "TARS Delivery 4 is a logistics company that provides delivery services.",
                    Author = "TARS",
                    Category = ECategory.Guide,
                    EmployeeId = 2,
                    Status = EStatusData.Active
                },
                new Blog
                {
                    Id = 5,
                    Title = "TARS Delivery 5",
                    Slug = "tars-delivery-5",
                    Content = "TARS Delivery 5 is a logistics company that provides delivery services.",
                    Author = "TARS",
                    Category = ECategory.Promotion,
                    EmployeeId = 2,
                    Status = EStatusData.Active
                },
                new Blog
                {
                    Id = 6,
                    Title = "TARS Delivery 6",
                    Slug = "tars-delivery-6",
                    Content = "TARS Delivery 6 is a logistics company that provides delivery services.",
                    Author = "TARS",
                    Category = ECategory.Guide,
                    EmployeeId = 2,
                    Status = EStatusData.Active
                }
            );
        }
    }
}
