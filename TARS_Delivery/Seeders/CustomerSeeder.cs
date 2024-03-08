using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders
{
    public class CustomerSeeder
    {
        public CustomerSeeder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer> ().HasData(
                Customer.Seed(1, 1, "Nguyễn Văn Customer", "0123456789", "Số 1, Đường 1, Phường 1, Quận 1, TP HCM", "TP HCM", "Quận 1", "Phuong 1", "700000", Models.Enums.ETypeInfo.Sender),
                Customer.Seed(2, 2, "Trần Thị Customer", "0987654321", "Số 2, Đường 2, Phường 2, Quận 2, TP HCM", "TP HCM", "Quận 2", "Phuong 2", "700000", Models.Enums.ETypeInfo.Sender),
                Customer.Seed(3, 3, "Lê Văn Customer", "044333333", "Số 3, Đường 3, Phường 3, Quận 3, TP HCM", "TP HCM", "Quan 3", "Phuong 3", "700000", Models.Enums.ETypeInfo.Receiver)
            );
        }
    }
}
